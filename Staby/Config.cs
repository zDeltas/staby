using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staby
{
    public class Config
    {
        private Main mainForm;
        private Overlay overlayForm;
        public int smoothingStrength = 30;
        public int smoothingInterpolation = 4;
        public int overlayScreen = 0;
        public int tolerance = 300;
        public bool manualInterpolation = false;
        public bool stayOnTop = false;
        public bool disableOverlay = false;
        public bool allScreens = false;
        public bool manualOverlayOverride = false;
        public bool disableCatchUp = false;
        public bool snapToCursor = false;
        public bool disableAutoDetection = false;
        public int mouseAction = 0;

        public Config(Main m, Overlay o)
        {
            mainForm = m;
            overlayForm = o;
            AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", "Staby.config");
        }

        public void LoadConfig(bool def = false)
        {
            if (def)
            {
                smoothingStrength = 30;
                smoothingInterpolation = 4;
                overlayScreen = 0;
                tolerance = 300;
                manualInterpolation = false;
                stayOnTop = false;
                disableOverlay = false;
                allScreens = false;
                manualOverlayOverride = false;
                disableCatchUp = false;
                snapToCursor = false;
                disableAutoDetection = false;

                // Main window resetting
                mainForm.checkBox_stayOnTop.Checked = false;
                mainForm.textBox_smoothingStrength.Text = smoothingStrength.ToString();
                mainForm.TopMost = false;

                // Cursor and overlay resetting
                overlayForm.cursorColor = Color.FromArgb(128, 128, 128);
                overlayForm.cursorFillColor = Color.FromArgb(255, 255, 254);
                overlayForm.cursorType = Overlay.CursorType.Bullseye;
                overlayForm.Show();
                overlayForm.Bounds = Screen.PrimaryScreen.Bounds;

            }
            else
            {
                try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    // Main window loading
                    smoothingStrength = int.Parse(config.AppSettings.Settings["Strength"].Value);
                    smoothingInterpolation = int.Parse(config.AppSettings.Settings["Interpolation"].Value);
                    manualInterpolation = bool.Parse(config.AppSettings.Settings["Manual Interpolation"].Value);
                    stayOnTop = bool.Parse(config.AppSettings.Settings["Stay On Top"].Value);
                    disableAutoDetection = bool.Parse(config.AppSettings.Settings["Disable Auto Detection"].Value);
                    mainForm.textBox_smoothingStrength.Text = smoothingStrength.ToString();
                    if (stayOnTop)
                    {
                        mainForm.checkBox_stayOnTop.Checked = true;
                        mainForm.TopMost = true;
                        overlayForm.TopMost = true;
                    }

                    // Cursor and overlay loading
                    overlayForm.cursorType = (Overlay.CursorType)Enum.Parse(typeof(Overlay.CursorType), config.AppSettings.Settings["Cursor Graphic"].Value);
                    overlayForm.cursorColor = ColorTranslator.FromHtml(config.AppSettings.Settings["Main Color"].Value);
                    overlayForm.cursorFillColor = ColorTranslator.FromHtml(config.AppSettings.Settings["Fill Color"].Value);
                    overlayScreen = int.Parse(config.AppSettings.Settings["Overlay Screen"].Value);
                    disableOverlay = bool.Parse(config.AppSettings.Settings["Disable Overlay"].Value);
                    allScreens = bool.Parse(config.AppSettings.Settings["All Screens"].Value);
                    manualOverlayOverride = bool.Parse(config.AppSettings.Settings["Manual Overlay Override"].Value);
                    if (disableOverlay) overlayForm.Hide();
                    overlayForm.Bounds = Screen.AllScreens[overlayScreen].Bounds;
                    if (allScreens) overlayForm.Bounds = new Rectangle(0, 0, SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);

                    // ...and everything else
                    disableCatchUp = bool.Parse(config.AppSettings.Settings["Disable Catch Up"].Value);
                    snapToCursor = bool.Parse(config.AppSettings.Settings["Snap To Cursor"].Value);
                    tolerance = int.Parse(config.AppSettings.Settings["Tolerance"].Value);
                    
                }
                catch
                {
                    // Quietly fail loading bad configs or no configs
                }
            }
        }

        public void SaveConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Strength");
            config.AppSettings.Settings.Add("Strength", smoothingStrength.ToString());
            config.AppSettings.Settings.Remove("Interpolation");
            config.AppSettings.Settings.Add("Interpolation", smoothingInterpolation.ToString());
            config.AppSettings.Settings.Remove("Manual Interpolation");
            config.AppSettings.Settings.Add("Manual Interpolation", manualInterpolation.ToString());
            config.AppSettings.Settings.Remove("Stay On Top");
            config.AppSettings.Settings.Add("Stay On Top", stayOnTop.ToString());
            config.AppSettings.Settings.Remove("Overlay Screen");
            config.AppSettings.Settings.Add("Overlay Screen", overlayScreen.ToString());
            config.AppSettings.Settings.Remove("Disable Overlay");
            config.AppSettings.Settings.Add("Disable Overlay", disableOverlay.ToString());
            config.AppSettings.Settings.Remove("All Screens");
            config.AppSettings.Settings.Add("All Screens", allScreens.ToString());
            config.AppSettings.Settings.Remove("Manual Overlay Override");
            config.AppSettings.Settings.Add("Manual Overlay Override", manualOverlayOverride.ToString());
            config.AppSettings.Settings.Remove("Override Bounds");
            config.AppSettings.Settings.Remove("Disable Catch Up");
            config.AppSettings.Settings.Add("Disable Catch Up", disableCatchUp.ToString());
            config.AppSettings.Settings.Remove("Snap to Cursor");
            config.AppSettings.Settings.Add("Snap to Cursor", snapToCursor.ToString());
            config.AppSettings.Settings.Remove("Cursor Graphic");
            config.AppSettings.Settings.Add("Cursor Graphic", overlayForm.cursorType.ToString());
            config.AppSettings.Settings.Remove("Main Color");
            config.AppSettings.Settings.Add("Main Color", ColorTranslator.ToHtml(overlayForm.cursorColor));
            config.AppSettings.Settings.Remove("Fill Color");
            config.AppSettings.Settings.Add("Fill Color", ColorTranslator.ToHtml(overlayForm.cursorFillColor));
            config.AppSettings.Settings.Remove("Disable Auto Detection");
            config.AppSettings.Settings.Add("Disable Auto Detection", disableAutoDetection.ToString());
            config.AppSettings.Settings.Remove("Tolerance");
            config.AppSettings.Settings.Add("Tolerance", tolerance.ToString());
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
