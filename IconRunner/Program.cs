using IconRunner.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace IconRunner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Core());
        }

        public class Core : ApplicationContext
        {
            private static ToolStripMenuItem aboutMenu = new ToolStripMenuItem("About", null, aboutMenuClick);
            private static ToolStripMenuItem settingsMenu = new ToolStripMenuItem("Settings", null, settingsMenuClick);
            private static ToolStripMenuItem pauseAniMenu = new ToolStripMenuItem("Pause animation", null, pauseAniMenuClick);
            private static ToolStripMenuItem exitMenu = new ToolStripMenuItem("Exit", null, Exit);

            private static NotifyIcon notifyIcon;
            private static Icon[] icons;

            private static Form settingsBox = new SettingsForm();
            private static Form aboutBox = new AboutForm();

            private static PerformanceCounter cpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            private static Timer animateTimer = new Timer();
            private static int current = 0;
            private static Timer cpuTimer = new Timer();

            public Core()
            {
                Application.ApplicationExit += new EventHandler(OnApplicationExit);

                ContextMenuStrip contextMenuStrip = new ContextMenuStrip(new Container());
                contextMenuStrip.Items.AddRange(new ToolStripItem[]
                {
                aboutMenu,
                settingsMenu,
                pauseAniMenu,
                exitMenu
                });

                notifyIcon = new NotifyIcon()
                {
                    Icon = Resources.appIcon,
                    ContextMenuStrip = contextMenuStrip,
                    Text = "0.0%",
                    Visible = true
                };

                cpuUsage.NextValue();

                UpdateIconSet();
                SetAnimation();
                CPUTick();
                StartObserveCPU();
                current = 1;
            }

            private static void aboutMenuClick(object sender, EventArgs e)
            {
                if (IsFormOpened("AboutForm")) return;
                aboutBox.ShowDialog();
            }

            private static void settingsMenuClick(object sender, EventArgs e)
            {
                if (IsFormOpened("SettingsForm")) return;
                settingsBox.ShowDialog();
                UpdateIconSet();
            }

            private static void UpdateIconSet()
            {
                string iconTheme = Settings.Default.iconTheme == "default" ? GetAppsUseTheme() : Settings.Default.iconTheme;
                List<Icon> list = new List<Icon>();
                ResourceManager resourceManager = Resources.ResourceManager;
                int i = 0;
                Icon ico = (Icon)resourceManager.GetObject($"{iconTheme}_{Settings.Default.iconName}_{0}");
                while (ico != null)
                {
                    list.Add(ico);
                    i++;
                    ico = (Icon)resourceManager.GetObject($"{iconTheme}_{Settings.Default.iconName}_{i}");
                }
                if (list.Count <= 0)
                {
                    list.Add(Resources.appIcon);
                }
                icons = list.ToArray();
            }

            private static string GetAppsUseTheme()
            {
                string keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";
                using (RegistryKey rKey = Registry.CurrentUser.OpenSubKey(keyName))
                {
                    object value;
                    if (rKey == null || (value = rKey.GetValue("SystemUsesLightTheme")) == null)
                    {
                        Console.WriteLine("Oh No! Couldn't get theme light/dark");
                        return "light";
                    }
                    int theme = (int)value;
                    return theme == 0 ? "dark" : "light";
                }
            }

            private void AnimationTick(object sender, EventArgs e)
            {
                if (icons.Length <= current) current = 0;
                notifyIcon.Icon = icons[current];
                current = (current + 1) % icons.Length;
            }

            private void SetAnimation()
            {
                animateTimer.Interval = 200;
                animateTimer.Tick += new EventHandler(AnimationTick);
            }

            private static void pauseAniMenuClick(object sender, EventArgs e)
            {
                if (cpuTimer.Enabled)
                {
                    cpuTimer.Stop();
                    animateTimer.Stop();
                    notifyIcon.Text = "paused";
                    pauseAniMenu.Checked = true;
                }
                else
                {
                    cpuTimer.Start();
                    animateTimer.Start();
                    notifyIcon.Text = "resuming";
                    pauseAniMenu.Checked = false;
                }
            }

            private void CPUTick()
            {
                float s = cpuUsage.NextValue();
                notifyIcon.Text = $"{s:f1}%";
                s = Settings.Default.aniScale / (float)Math.Max(1.0f, Math.Min(20.0f, s / 10.0f));
                animateTimer.Stop();
                animateTimer.Interval = Settings.Default.constSpeed ? Settings.Default.aniScale : (int)s;
                animateTimer.Start();
            }

            private void ObserveCPUTick(object sender, EventArgs e)
            {
                CPUTick();
            }

            private void StartObserveCPU()
            {
                cpuTimer.Interval = 3000;
                cpuTimer.Tick += new EventHandler(ObserveCPUTick);
                cpuTimer.Start();
            }

            private static bool IsFormOpened(string formName)
            {
                FormCollection fc = Application.OpenForms;

                foreach (Form frm in fc)
                {
                    //iterate through
                    if (frm.Name == formName)
                    {
                        return true;
                    }
                }
                return false;
            }

            private static void OnApplicationExit(object sender, EventArgs e)
            {

            }

            private static void Exit(object sender, EventArgs e)
            {
                cpuUsage.Close();
                animateTimer.Stop();
                cpuTimer.Stop();
                notifyIcon.Visible = false;
                Application.Exit();
            }
        }
    }
}
