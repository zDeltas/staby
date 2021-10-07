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
        public int smoothingPower = 30;
        public int smoothingInterpolation = 4;
        public bool sotOn = true;
        public bool disableOverlay = false;
        public bool allScreens = false;
        public bool disableCatchUp = false;
        public bool snapToCursor = false;
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
                smoothingPower = 30;
                smoothingInterpolation = 4;
                sotOn = true;
                disableOverlay = false;
                allScreens = false;
                disableCatchUp = false;
                snapToCursor = false;

            }
            else
            {
                try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    // Main window loading
                    smoothingPower = int.Parse(config.AppSettings.Settings["Power"].Value);
                    smoothingInterpolation = int.Parse(config.AppSettings.Settings["Interpolation"].Value);
                    sotOn = bool.Parse(config.AppSettings.Settings["Stay On Top"].Value);
                    mainForm.textBox_smoothingPower.Text = smoothingPower.ToString();
                    if (true)
                    {
                        mainForm.sotOn = true;
                        overlayForm.TopMost = true;
                    }

                    // ...and everything else
                    disableCatchUp = bool.Parse(config.AppSettings.Settings["Disable Catch Up"].Value);
                    
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
            config.AppSettings.Settings.Remove("Power");
            config.AppSettings.Settings.Add("Power", smoothingPower.ToString());
            config.AppSettings.Settings.Remove("Interpolation");
            config.AppSettings.Settings.Add("Interpolation", smoothingInterpolation.ToString());
            config.AppSettings.Settings.Remove("Stay On Top");
            config.AppSettings.Settings.Add("Stay On Top", sotOn.ToString());
            config.AppSettings.Settings.Remove("Disable Overlay");
            config.AppSettings.Settings.Add("Disable Overlay", disableOverlay.ToString());
            config.AppSettings.Settings.Remove("All Screens");
            config.AppSettings.Settings.Add("All Screens", allScreens.ToString());
            config.AppSettings.Settings.Remove("Override Bounds");
            config.AppSettings.Settings.Remove("Disable Catch Up");
            config.AppSettings.Settings.Add("Disable Catch Up", disableCatchUp.ToString());
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
