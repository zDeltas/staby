using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Staby
{
    public partial class Main : Form
    {
        public Config config;
        public Overlay overlay = new Overlay();
        private List<Point> linePoints = new List<Point>();
        private List<Point> smoothPoints = new List<Point>();
        private readonly System.Timers.Timer lineSmoothingTimer = new System.Timers.Timer();
        private readonly System.Timers.Timer lineProcessingTimer = new System.Timers.Timer();

        private System.Timers.Timer testTimer = new System.Timers.Timer();

        public int virtualWidth = GetSystemMetrics(78);
        public int virtualHeight = GetSystemMetrics(79);
        public int virtualLeft = GetSystemMetrics(76);
        public int virtualTop = GetSystemMetrics(77);
        public bool smoothingOn = false;
        public bool isDrawing = false;
        public bool mouseMoving = false;
        private Point position = new Point(0, 0);
        private Point lastPosition = new Point(0, 0);
        private bool isDrag = false;
        private int i = 0;

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

            testTimer.Elapsed += OnTimedEvent;
            testTimer.AutoReset = false;

            // Mouse smoothing updater
            lineSmoothingTimer.Elapsed += new ElapsedEventHandler(LineSmoothingUpdate);
            lineSmoothingTimer.Interval = 5;

            // Line processing updater
            lineProcessingTimer.Elapsed += new ElapsedEventHandler(LineProcessingUpdate);
            lineProcessingTimer.Interval = config.smoothingStrength;

            // Register a raw input listener
            int size = Marshal.SizeOf(typeof(RawInputDevice));
            RawInputDevice[] devices = new RawInputDevice[1];
            devices[0].UsagePage = 1;
            devices[0].Usage = 2;
            devices[0].Flags = 0x00000100;
            devices[0].Target = Handle;
            RegisterRawInputDevices(devices, 1, size);
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
                // B-Spline smoothing
                if (linePoints.Count > 3)
                {
                    int i;
                    int splineX;
                    int splineY;
                    double[] a = new double[5];
                    double[] b = new double[5];
                    Point p1 = linePoints[0];
                    Point p2 = linePoints[1];
                    Point p3 = linePoints[2];
                    Point p4 = linePoints[3];

                    a[0] = (-p1.X + 3 * p2.X - 3 * p3.X + p4.X) / 6.0;
                    a[1] = (3 * p1.X - 6 * p2.X + 3 * p3.X) / 6.0;
                    a[2] = (-3 * p1.X + 3 * p3.X) / 6.0;
                    a[3] = (p1.X + 4 * p2.X + p3.X) / 6.0;
                    b[0] = (-p1.Y + 3 * p2.Y - 3 * p3.Y + p4.Y) / 6.0;
                    b[1] = (3 * p1.Y - 6 * p2.Y + 3 * p3.Y) / 6.0;
                    b[2] = (-3 * p1.Y + 3 * p3.Y) / 6.0;
                    b[3] = (p1.Y + 4 * p2.Y + p3.Y) / 6.0;

                    smoothPoints.Add(new Point((int)a[3], (int)b[3]));

                    for (i = 1; i <= config.smoothingInterpolation - 1; i++)
                    {
                        float t = Convert.ToSingle(i) / Convert.ToSingle(config.smoothingInterpolation);
                        splineX = (int)((a[2] + t * (a[1] + t * a[0])) * t + a[3]);
                        splineY = (int)((b[2] + t * (b[1] + t * b[0])) * t + b[3]);
                        if (smoothPoints.Last<Point>() != new Point(splineX, splineY))
                        {
                            smoothPoints.Add(new Point(splineX, splineY));
                        }
                    }
                    linePoints.RemoveAt(0);
                }
                else if (MouseHook.GetCursorPosition() != position && isDrawing)
                {
                    if (config.disableCatchUp)
                    {
                        if (mouseMoving)
                        {
                            linePoints.Add(position);
                        }
                    }
                    else
                    {
                        linePoints.Add(position);
                    }
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
                if (smoothPoints.Count > 0 && isDrawing)
                {
                    if (config.disableCatchUp)
                    {
                        if (mouseMoving)
                        {
                            MouseHook.SetCursorPos(smoothPoints[0].X, smoothPoints[0].Y);
                            smoothPoints.RemoveAt(0);
                        }
                    }
                    else
                    {
                        MouseHook.SetCursorPos(smoothPoints[0].X, smoothPoints[0].Y);
                        smoothPoints.RemoveAt(0);
                    }
                }
            }
            catch
            {
                // Fail smoothing gracefully
            }

            if (!isDrawing)
            {
                smoothPoints.Clear();
                lineSmoothingTimer.Stop();
                if (!config.snapToCursor) MouseHook.SetCursorPos(guidePos.X, guidePos.Y);
                MouseHook.moveEnabled = true;
                MouseHook.downEnabled = true;
            }
        }

        private void MouseMoveHandler(object sender, EventArgs e)
        {
            testTimer.Enabled = false;
            overlay.cursorPos = MouseHook.GetCursorPosition();
            overlay.Invalidate();
            testTimer.Enabled = true;
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
            
            Thread.Sleep(2000);
            if (lastUnMove == MouseHook.GetCursorPosition())
            {
                if(config.mouseAction >= 0 && config.mouseAction <= 3)
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

            testTimer.Stop();
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
        private void button_SmoothOnOff_Click(object sender, EventArgs e)
        {
            if (smoothingOn)
            {
                // Off
                button_smoothOnOff.BackColor = Color.Gainsboro;
                MouseHook.moveEnabled = true;
                MouseHook.downEnabled = true;
                smoothingOn = false;
                isDrawing = false;
                lineSmoothingTimer.Stop();
                lineProcessingTimer.Stop();
            }
            else
            {
                // On
                button_smoothOnOff.BackColor = Color.Azure;
                linePoints.Clear();
                smoothPoints.Clear();
                position = MouseHook.GetCursorPosition();
                smoothPoints.Add(position);
                MouseHook.moveEnabled = false;
                isDrawing = true;
                lineProcessingTimer.Start();
                lineSmoothingTimer.Start();
                smoothingOn = true;
            }
        }

        private void trackBar_smoothStrength_Scroll(object sender, EventArgs e)
        {
            config.smoothingStrength = trackBar_smoothingStrength.Value;
            lineProcessingTimer.Interval = config.smoothingStrength;
            textBox_smoothingStrength.Text = config.smoothingStrength.ToString();
            config.smoothingInterpolation = (int)Math.Round(config.smoothingStrength * 0.15);
        }

        private void textBox_smoothingStrength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox_smoothingStrength.Text) < 1)
                {
                    config.smoothingStrength = 1;
                }
                else if (int.Parse(textBox_smoothingStrength.Text) > 100)
                {
                    config.smoothingStrength = 100;
                }
                else
                {
                    config.smoothingStrength = int.Parse(textBox_smoothingStrength.Text);
                }
            }
            catch
            {
                config.smoothingStrength = 1;
            }
            lineProcessingTimer.Interval = config.smoothingStrength;
            trackBar_smoothingStrength.Value = config.smoothingStrength;
            textBox_smoothingStrength.Text = config.smoothingStrength.ToString();
            config.smoothingInterpolation = (int)Math.Round(config.smoothingStrength * 0.15);
        }


        private void checkBox_stayOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_stayOnTop.Checked)
            {
                TopMost = true;
                overlay.TopMost = true;
                config.stayOnTop = true;
            }
            else
            {
                TopMost = false;
                config.stayOnTop = false;
            }
        }
        
        private void button_displayOverlay(object sender, EventArgs e)
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

        private void ToolStripMenuItem_restoreDefaults_Click(object sender, EventArgs e)
        {
            config.LoadConfig(true);
            MessageBox.Show("Default settings restored.", "Staby", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stabilization(object sender, EventArgs e)
        {
            button1.Text = "TODO";
            config.smoothingStrength = SetAutoSmoothingStrengh();
            lineProcessingTimer.Interval = config.smoothingStrength;
            textBox_smoothingStrength.Text = config.smoothingStrength.ToString();
            config.smoothingInterpolation = (int)Math.Round(config.smoothingStrength * 0.15);
        }

        private static int SetAutoSmoothingStrengh()
        {
            List<Point> positions = new List<Point>();
            List<int> positionsX = new List<int>();
            List<int> positionsY = new List<int>();

            for (int i =0; i<100; i++)
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
            int dif = ((positionXMax-positionXMin) + (positionYMax-positionYMin))/2;
            int sensi = dif * 2;

            if (sensi>100)
            {
                return 100;
            }
            if (sensi == 0)
            {
                return 1;
            }
            return sensi;

        }


        // Mouse Action
        private void MouseReset(object sender, EventArgs e)
        {
            config.mouseAction = 0;
        }

        private void MouseLeftClick(object sender, EventArgs e)
        {
            config.mouseAction = 1;

        }

        private void MouseRightClick(object sender, EventArgs e)
        {
            config.mouseAction = 2;
        }

        private void MouseDoublClick(object sender, EventArgs e)
        {
            config.mouseAction = 3;
        }

        private void MouseDragClick(object sender, EventArgs e)
        {
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
