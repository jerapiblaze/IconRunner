using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IconRunner.Properties;
using Microsoft.Win32;
using System.Diagnostics;

namespace IconRunner
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            initializeValues();
        }

        private void initializeValues()
        {
            for (int i = 0; i < iconPackValue.Items.Count; i++)
            {
                if (Settings.Default.iconName == iconPackValue.Items[i].ToString())
                {
                    iconPackValue.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < iconVariantValue.Items.Count; i++)
            {
                if (Settings.Default.iconTheme == iconVariantValue.Items[i].ToString())
                {
                    iconVariantValue.SelectedIndex = i;
                    break;
                }
            }

            scaleValue.Text = Settings.Default.aniScale.ToString();

            startupCheck.Checked = IsStartupEnabled();

            constantSpeedCheck.Checked = Settings.Default.constSpeed;
        }

        private bool IsStartupEnabled()
        {
            string keyName = @"Software\Microsoft\Windows\CurrentVersion\Run";
            using (RegistryKey rKey = Registry.CurrentUser.OpenSubKey(keyName))
            {
                return (rKey.GetValue(Application.ProductName) != null) ? true : false;
            }
        }

        private void SetStartup(bool enabled)
        {
           string keyName = @"Software\Microsoft\Windows\CurrentVersion\Run";
            using (RegistryKey rKey = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (enabled)
                {
                    rKey.SetValue(Application.ProductName, Process.GetCurrentProcess().MainModule.FileName);
                }
                else
                {
                    rKey.DeleteValue(Application.ProductName, false);
                }
                rKey.Close();
            }
        }

        private void saveSettingsButtion_Click(object sender, EventArgs e)
        {
            Settings.Default.iconName = iconPackValue.SelectedItem.ToString();
            Settings.Default.iconTheme = iconVariantValue.SelectedItem.ToString();
            if (Int32.TryParse(scaleValue.Text, out int aniScale))
            {
                Settings.Default.aniScale = aniScale;
            }
            SetStartup(startupCheck.Checked);
            Settings.Default.constSpeed = constantSpeedCheck.Checked;

            Settings.Default.Save();
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            Settings.Default.Save();
            this.Close();
        }
    }
}