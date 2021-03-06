using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Staby
{
    public partial class Main : Form
    {
        public Config config;
        public Overlay overlay = new Overlay();
        private List<Point> LinePoints = new List<Point>();
        private List<Point> SmoothPoints = new List<Point>();

        private readonly System.Timers.Timer lineSmoothingTimer = new System.Timers.Timer();
        private readonly System.Timers.Timer lineProcessingTimer = new System.Timers.Timer();
        private System.Timers.Timer TimerBeforeClick = new System.Timers.Timer();

        public bool sotOn = false;
        public bool smoothingOn = false;
        public bool isDrawing = false;
        public bool mouseMoving = false;
        private Point position = new Point(0, 0);
        private Point lastPosition = new Point(0, 0);
        private bool isDrag = false;
        public int i = 0;
        public Main()
        {
            InitializeComponent();

            // Initialize the config file
            config = new Config(this, overlay);

            // Overlay setup
            overlay.Show();
            overlay.TopMost = true;
            overlay.Bounds = Screen.AllScreens[0].Bounds;

            // Attempt to load the config file, if any
            config.LoadConfig();

            // Low level mouse hook (MouseHook.cs)
            MouseHook.Start();
            MouseHook.MouseMoveHooked += new EventHandler(MouseMoveHandler);

            TimerBeforeClick.Elapsed += OnTimedEvent;
            TimerBeforeClick.AutoReset = false;

            // Mouse smoothing updater
            lineSmoothingTimer.Elapsed += new ElapsedEventHandler(LineSmoothingUpdate);
            lineSmoothingTimer.Interval = 5;

            // Line processing updater
            lineProcessingTimer.Elapsed += new ElapsedEventHandler(LineProcessingUpdate);
            lineProcessingTimer.Interval = config.smoothingPower;

            // Register a raw input listener
            int size = Marshal.SizeOf(typeof(RawInputDevice));
            RawInputDevice[] devices = new RawInputDevice[1];
            devices[0].UsagePage = 1;
            devices[0].Usage = 2;
            devices[0].Flags = 0x00000100;
            devices[0].Target = Handle;
            RegisterRawInputDevices(devices, 1, size);

            this.BackColor = Color.Gainsboro;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        // Reading global raw input
        private void VirtualCursorUpdate(ref Message m)
        {
            int RidInput = 0x10000003;
            int headerSize = Marshal.SizeOf(typeof(RawInputHeader));
            int size = Marshal.SizeOf(typeof(RawInput));
            RawInput input;
            GetRawInputData(m.LParam, RidInput, out input, ref size, headerSize);
            RawMouse mouse = input.Mouse;

            if (isDrawing)
            {
                Point p = new Point(position.X + mouse.LastX, position.Y + mouse.LastY);
                position = p;
                overlay.cursorPos = p;
                overlay.Invalidate();
            }
        }

        // Line processing (interlopation)
        private void LineProcessingUpdate(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (LinePoints.Count > 3)
                {
                    int sX;
                    int sY;
                    double[] a = new double[5];
                    double[] b = new double[5];
                    Point p1 = LinePoints[0];
                    Point p2 = LinePoints[1];
                    Point p3 = LinePoints[2];
                    Point p4 = LinePoints[3];

                    a[0] = (-p1.X + 3 * p2.X - 3 * p3.X + p4.X) / 6.0;
                    a[1] = (3 * p1.X - 6 * p2.X + 3 * p3.X) / 6.0;
                    a[2] = (-3 * p1.X + 3 * p3.X) / 6.0;
                    a[3] = (p1.X + 4 * p2.X + p3.X) / 6.0;
                    b[0] = (-p1.Y + 3 * p2.Y - 3 * p3.Y + p4.Y) / 6.0;
                    b[1] = (3 * p1.Y - 6 * p2.Y + 3 * p3.Y) / 6.0;
                    b[2] = (-3 * p1.Y + 3 * p3.Y) / 6.0;
                    b[3] = (p1.Y + 4 * p2.Y + p3.Y) / 6.0;

                    SmoothPoints.Add(new Point((int)a[3], (int)b[3]));

                    for (i = 1; i <= config.smoothingInterpolation - 1; i++)
                    {
                        float t = Convert.ToSingle(i) / Convert.ToSingle(config.smoothingInterpolation);

                        sX = (int)((a[2] + t * (a[1] + t * a[0])) * t + a[3]);
                        sY = (int)((b[2] + t * (b[1] + t * b[0])) * t + b[3]);
                        if (SmoothPoints.Last<Point>() != new Point(sX, sY))
                        {
                            SmoothPoints.Add(new Point(sX, sY));
                        }
                    }
                    LinePoints.RemoveAt(0);
                }
                else if (MouseHook.GetCursorPosition() != position && isDrawing)
                {
                    LinePoints.Add(position);
                }
            }
            catch
            {
                // Fail processing gracefully
            }
        }

        // Line smoothing
        private void LineSmoothingUpdate(object sender, ElapsedEventArgs e)
        {
            Point guidePos = position;
            if (lastPosition == guidePos)
            {
                mouseMoving = false;
            }
            else
            {
                mouseMoving = true;
            }
            lastPosition = guidePos;

            try
            {
                // Begin smoothing only if we have points to work with and if drawing
                if (SmoothPoints.Count > 0 && isDrawing)
                {
                    if (config.disableCatchUp)
                    {
                        if (mouseMoving)
                        {
                            MouseHook.SetCursorPos(SmoothPoints[0].X, SmoothPoints[0].Y);
                            SmoothPoints.RemoveAt(0);
                        }
                    }
                    else
                    {
                        MouseHook.SetCursorPos(SmoothPoints[0].X, SmoothPoints[0].Y);
                        SmoothPoints.RemoveAt(0);
                    }
                }
            }
            catch
            {
                // Fail smoothing gracefully
            }

            if (!isDrawing)
            {
                SmoothPoints.Clear();
                lineSmoothingTimer.Stop();
                if (!config.snapToCursor) MouseHook.SetCursorPos(guidePos.X, guidePos.Y);
                MouseHook.moveEnabled = true;
            }
        }

        private void MouseMoveHandler(object sender, EventArgs e)
        {
            TimerBeforeClick.Enabled = false;
            overlay.cursorPos = MouseHook.GetCursorPosition();
            overlay.Invalidate();
            TimerBeforeClick.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Point lastUnMove;
            if (smoothingOn)
            {
                lastUnMove = lastPosition;
            }
            else
            {
                lastUnMove = MouseHook.GetCursorPosition();
            }

            Thread.Sleep(config.clickDelay);
            if (lastUnMove == MouseHook.GetCursorPosition())
            {
                if (config.mouseAction >= 0 && config.mouseAction <= 3)
                {
                    ClickEvent.Click(config.mouseAction, MouseHook.GetCursorPosition());
                }
                else if (config.mouseAction == 4 || isDrag)
                {
                    if (!isDrag)
                    {
                        ClickEvent.Click(config.mouseAction, MouseHook.GetCursorPosition());
                        isDrag = true;
                    }
                    else
                    {
                        ClickEvent.Click(config.mouseAction + 1, MouseHook.GetCursorPosition());
                        isDrag = false;
                    }

                }
            }

            TimerBeforeClick.Stop();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_INPUT = 0xFF;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    break;
            }
            if (m.Msg == WM_INPUT && smoothingOn)
            {
                this.VirtualCursorUpdate(ref m);
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        // Interface handling
        private void SmoothOnOffClickBtn(object sender, EventArgs e)
        {
            if (smoothingOn)
            {
                // Off
                button_smoothOnOff.BackColor = Color.Gainsboro;
                MouseHook.moveEnabled = true;
                smoothingOn = false;
                isDrawing = false;
                lineSmoothingTimer.Stop();
                lineProcessingTimer.Stop();
            }
            else
            {
                // On
                button_smoothOnOff.BackColor = Color.Lime;
                LinePoints.Clear();
                SmoothPoints.Clear();
                position = MouseHook.GetCursorPosition();
                SmoothPoints.Add(position);
                MouseHook.moveEnabled = false;
                isDrawing = true;
                lineProcessingTimer.Start();
                lineSmoothingTimer.Start();
                smoothingOn = true;
            }
        }

        private void TrackBarSmoothPower(object sender, EventArgs e)
        {
            config.smoothingPower = trackBar_smoothingPower.Value;
            lineProcessingTimer.Interval = config.smoothingPower;
            textBox_smoothingPower.Text = config.smoothingPower.ToString();
            config.smoothingInterpolation = (int)Math.Round(config.smoothingPower * 0.15);
        }

        private void TextBoxSmoothingPower(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox_smoothingPower.Text) < 1)
                {
                    config.smoothingPower = 1;
                }
                else if (int.Parse(textBox_smoothingPower.Text) > 100)
                {
                    config.smoothingPower = 100;
                }
                else
                {
                    config.smoothingPower = int.Parse(textBox_smoothingPower.Text);
                }
            }
            catch
            {
                config.smoothingPower = 1;
            }
            lineProcessingTimer.Interval = config.smoothingPower;
            trackBar_smoothingPower.Value = config.smoothingPower;
            textBox_smoothingPower.Text = config.smoothingPower.ToString();
            config.smoothingInterpolation = (int)Math.Round(config.smoothingPower * 0.15);
        }

        private void ClickDelayInput(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox_clickDelay.Text) < 1)
                {
                    config.clickDelay = 1;
                }
                else if (int.Parse(textBox_clickDelay.Text) > 10000)
                {
                    config.clickDelay = 10000;
                }
                else
                {
                    config.clickDelay = int.Parse(textBox_clickDelay.Text);
                }
            }
            catch
            {
                config.clickDelay = 2000;
            }
            textBox_clickDelay.Text = config.clickDelay.ToString();
        }

        //Stay on top
        private void SotClickBtn(object sender, EventArgs e)
        {
            if (!sotOn)
            //on
            {
                SotBtn.BackColor = Color.Gainsboro;

                TopMost = false;
                overlay.TopMost = false;
                config.sotOn = false;
                sotOn = true;

            }
            //off
            else
            {
                SotBtn.BackColor = Color.Lime;

                TopMost = true;
                overlay.TopMost = true;
                config.sotOn = true;
                sotOn = false;

            }
        }

        private void DisplayOverlayBtn(object sender, EventArgs e)
        {
            if (!config.disableOverlay)
            {
                overlay.Hide();
                config.disableOverlay = true;
            }
            else
            {
                overlay.Show();
                config.disableOverlay = false;
            }
        }

        private void ToolStripMenuItem_saveConfig_Click(object sender, EventArgs e)
        {
            config.SaveConfig();
            MessageBox.Show("Configuration settings saved to: Staby.config", "Staby", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stabilization(object sender, EventArgs e)
        {
            StabilizationBtn.Text = "GO";
            config.smoothingPower = SetAutoSmoothingPower();
            lineProcessingTimer.Interval = config.smoothingPower;
            textBox_smoothingPower.Text = config.smoothingPower.ToString();
            config.smoothingInterpolation = (int)Math.Round(config.smoothingPower * 0.15);
            StabilizationBtn.Text = "";
        }

        private static int SetAutoSmoothingPower()
        {
            List<Point> positions = new List<Point>();
            List<int> positionsX = new List<int>();
            List<int> positionsY = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                var t = Task.Run(async delegate
                {
                    await Task.Delay(20);
                });
                t.Wait();
                var position = MouseHook.GetCursorPosition();
                positions.Add(position);
            }

            foreach (Point item in positions)
            {
                positionsX.Add(item.X);
                positionsY.Add(item.Y);
            }

            var positionXMax = positionsX.Max();
            var positionXMin = positionsX.Min();
            var positionYMax = positionsY.Max();
            var positionYMin = positionsY.Min();
            int dif = ((positionXMax - positionXMin) + (positionYMax - positionYMin)) / 2;
            int sensi = dif * 2;

            if (sensi > 100)
            {
                return 100;
            }
            if (sensi == 0)
            {
                return 1;
            }
            return sensi;

        }

        private void ColorReset()
        {
            MouseLeftBtn.BackColor = Color.Gainsboro;
            MouseRightBtn.BackColor = Color.Gainsboro;
            MouseDoubleBtn.BackColor = Color.Gainsboro;
            MouseDragBtn.BackColor = Color.Gainsboro;
        }

        // Mouse Action
        private void MouseReset(object sender, EventArgs e)
        {
            ColorReset();
            config.mouseAction = 0;
        }

        private void MouseLeftClick(object sender, EventArgs e)
        {
            ColorReset();
            MouseLeftBtn.BackColor = Color.Lime;
            config.mouseAction = 1;
        }

        private void ToolStripMenuItem_help_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Help>().Count() != 1)
            {
                Help help = new Help();
                help.Owner = this;
                help.MinimizeBox = false;
                help.MaximizeBox = false;
                help.Show();
            }
        }

        private void MouseRightClick(object sender, EventArgs e)
        {
            ColorReset();
            MouseRightBtn.BackColor = Color.Lime;
            config.mouseAction = 2;
        }

        private void MouseDoublClick(object sender, EventArgs e)
        {
            ColorReset();
            MouseDoubleBtn.BackColor = Color.Lime;
            config.mouseAction = 3;
        }

        private void MouseDragClick(object sender, EventArgs e)
        {
            ColorReset();
            MouseDragBtn.BackColor = Color.Lime;
            config.mouseAction = 4;
        }


        // Raw input hook
        private struct RawInputDevice
        {
            public short UsagePage;
            public short Usage;
            public int Flags;
            public IntPtr Target;
        }

        private struct RawInputHeader
        {
            public int Type;
            public int Size;
            public IntPtr Device;
            public IntPtr WParam;
        }

        private struct RawInput
        {
            public RawInputHeader Header;
            public RawMouse Mouse;
        }

        private struct RawMouse
        {
            public short Flags;
            public short ButtonFlags;
            public short ButtonData;
            public int RawButtons;
            public int LastX;
            public int LastY;
            public int Extra;
        }

        //Dll importing
        [DllImport("user32.dll")]
        private static extern int RegisterRawInputDevices(RawInputDevice[] devices, int number, int size);

        [DllImport("user32.dll")]
        private static extern int GetRawInputData(IntPtr rawInput, int command, out RawInput data, ref int size, int headerSize);

        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);

    }
}
