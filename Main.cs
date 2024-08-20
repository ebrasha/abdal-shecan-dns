using System.ComponentModel;
using Abdal_Security_Group_App.Core;
using System.Diagnostics;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using Telerik.WinControls.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Abdal_Security_Group_App
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        public string ip_update_status = "";
        private bool stop_op_status = false;
        private string abdal_app_name = Assembly.GetExecutingAssembly().GetName().ToString().Split(',')[0];
        private AbdalSoundPlayer ab_player = new AbdalSoundPlayer();

        private string abdal_app_name_for_url = "Abdal Shecan DNS".ToLower().Replace(' ', '-');


        public Main()
        {
            InitializeComponent();
            //change form title
            Version version = Assembly.GetExecutingAssembly().GetName().Version!;
            Text = abdal_app_name + " " + version.Major + "." + version.Minor;

            // Call Global Chilkat Unlock
            ChilkatMng.UnlockChilkat();
            AntiDupProc.AntiDuplicationProcess();
        }

        #region Dragable Form Start

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        #endregion

        private async void Main_Load(object sender, EventArgs e)
        {
            TimeSpan selectedTimeSpan = (TimeSpan)TimeSpanPickerIpU.Value;
            int seconds = selectedTimeSpan.Seconds;

            GlobalpUpdaterTimer.Instance.Initialize(seconds * 1000, () =>
            {
                if (bg_IpUpdatre.IsBusy != true)
                {
                    bg_IpUpdatre.RunWorkerAsync();
                }
            });
            GlobalpUpdaterTimer.Instance.Stop();


            if (!File.Exists(PubVar.configFilePath))
            {
                ShecanConfig.SaveConfig(
                    PubVar.configFilePath,
                    "no",
                    UpdateIpPassword.Text,
                    "no",
                    selectedTimeSpan.ToString()
                );
                switchIPUpdater.Value = false;
                ShecanPro.Value = false;
            }

            // Get Config 
            Dictionary<string, string> config = ShecanConfig.RetrieveConfig(PubVar.configFilePath);
            // ProShecan Status
            if (config["shecan_pro"] == "yes")
            {
                ShecanPro.Value = true;
            }
            else
            {
                ShecanPro.Value = false;
            }

            // IP Password Update
            UpdateIpPassword.Text = config["shecan_ip_updater_code"];

            // Updater Time Status
            if (config["shekan_ip_updater_status"] == "yes")
            {
                switchIPUpdater.Value = true;
                GlobalpUpdaterTimer.Instance.Start();
                TimeSpanPickerIpU.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
            }
            else
            {
                GlobalpUpdaterTimer.Instance.Stop();
                switchIPUpdater.Value = false;
                TimeSpanPickerIpU.BackColor = System.Drawing.Color.Crimson;
            }


            TimeSpanPickerIpU.Value = TimeSpan.Parse(config["shecan_ip_updater_time_value"]);


            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces)
            {
                nicList.Items.Add(adapter.Name);
            }
            await UpdateChecker.CheckForUpdateAsync();
        }

        private void cmdHandelCommand(string userCommand)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(userCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            if (PubVar.cmdLogging)
            {
                radRichTextEditorResult.Invoke((MethodInvoker)delegate
                {
                    radRichTextEditorResult.AppendText(cmd.StandardOutput.ReadToEnd() + Environment.NewLine);
                    radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                    radRichTextEditorResult.ScrollToCaret();
                });
            }
        }

        static List<string> GetNetworkInterfaces()
        {
            var networkInterfaces = new List<string>();
            var searcher =
                new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                networkInterfaces.Add(queryObj["Description"].ToString());
            }

            return networkInterfaces;
        }

        private void menuItem_github_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://github.com/ebrasha/" + abdal_app_name_for_url)
            { UseShellExecute = true });
        }

        private void menuItem_gitlab_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.Start(new ProcessStartInfo("https://gitlab.com/Prof.Shafiei/" + abdal_app_name_for_url)
            { UseShellExecute = true });
        }

        private void menuItem_about_us_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("checkbox");
            about_us about_form = new Abdal_Security_Group_App.about_us();
            about_form.ShowDialog();
            about_form.TopMost = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab_player.sPlayer("checkbox");
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void bg_worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                ShowDeskAlert("توسط کاربر متوقف شد", "cancel");
            }
            else if (e.Error != null)
            {
                ShowDeskAlert(e.Error.Message, "error");
            }
            else
            {
                ShowDeskAlert("انجام شد", stop_op_status ? "cancel" : "shecan-done");
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!bg_worker.IsBusy)
            {
                bg_worker.RunWorkerAsync();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void irDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://alphajet.ir/abdal-donation") { UseShellExecute = true });
        }

        private void EnDonationBtn_Click(object sender, EventArgs e)
        {
            ab_player.sPlayer("coin");
            Process.Start(new ProcessStartInfo("https://ebrasha.com/abdal-donation") { UseShellExecute = true });
        }

        private void bg_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Save To config file

            TimeSpan selectedTimeSpan = (TimeSpan)TimeSpanPickerIpU.Value;
            int seconds = selectedTimeSpan.Seconds;

            // UpdateTimer
            GlobalpUpdaterTimer.Instance.UpdateInterval(seconds * 1000);
            GlobalpUpdaterTimer.Instance.Start();

            ShecanConfig.SaveConfig(
                PubVar.configFilePath,
                (ShecanPro.Value) ? "yes" : "no",
                UpdateIpPassword.Text,
                (switchIPUpdater.Value) ? "yes" : "no",
                selectedTimeSpan.ToString()
            );


            NetworkInterface[] interfaces_f1 = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces_f1)
            {
                cmdHandelCommand($"netsh interface ipv4 set dnsservers    \"{adapter.Name}\"  dhcp");
            }

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("دی ان اس سیستم شما بر روی حالت پیشفرض شبکه شما تغییر یافت." +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });

            // Clean DNS Cache
            cmdHandelCommand("ipconfig /flushdns");
            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("گش دی ان اس شما حذف شد" + Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });
            // Clean Route
            cmdHandelCommand(
                "for /f \"skip=3 tokens=4,6\" %e in ('netsh int ipv4 sh route store^=persistent ^| findstr -v 0.0.0.0/0') do route delete -4 -p %e %f");
            cmdHandelCommand(
                "for /f \"skip=3 tokens=4,6\" %e in ('netsh int ipv6 sh route store^=persistent ^| findstr -v ::/0') do route delete -6 -p %e %f");

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("کش روت های سیستم شما حذف شد تا شکن بدون اختلال کار کند" +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });


            if (ShecanPro.Value)
            {
                if (nicList.Text == "همه کارت شبکه ها")
                {
                    NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (NetworkInterface adapter in interfaces)
                    {
                        cmdHandelCommand(
                            $"netsh interface ipv4 add dnsservers    \"{adapter.Name}\"  address=178.22.122.101  index=1");
                        cmdHandelCommand(
                            $"netsh interface ipv4 add dnsservers    \"{adapter.Name}\"  address=185.51.200.1  index=2");
                    }

                    radRichTextEditorResult.Invoke((MethodInvoker)delegate
                    {
                        radRichTextEditorResult.AppendText(
                            "دی ان اس های شکن حرفه ای روی تمامی کارت شبکه های شما ست شد" + Environment.NewLine);
                        radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                        radRichTextEditorResult.ScrollToCaret();
                    });
                }
                else
                {
                    cmdHandelCommand(
                        $"netsh interface ipv4 add dnsservers    \"{nicList.Text}\"  address=178.22.122.101 index=1");
                    cmdHandelCommand(
                        $"netsh interface ipv4 add dnsservers    \"{nicList.Text}\"  address=185.51.200.1 index=2");

                    radRichTextEditorResult.Invoke((MethodInvoker)delegate
                    {
                        radRichTextEditorResult.AppendText("دی ان اس شکن حرفه ای روی کارت شبکه مورد نظر ست شد" +
                                                           Environment.NewLine);
                        radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                        radRichTextEditorResult.ScrollToCaret();
                    });
                }


                switchIPUpdater.Value = true;


                GlobalpUpdaterTimer.Instance.Start();
            }
            else
            {
                // Free Shecan
                if (nicList.Text == "همه کارت شبکه ها")
                {
                    NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (NetworkInterface adapter in interfaces)
                    {
                        cmdHandelCommand(
                            $"netsh interface ipv4 add dnsservers    \"{adapter.Name}\"   address=178.22.122.100  index=1");
                        cmdHandelCommand(
                            $"netsh interface ipv4 add dnsservers    \"{adapter.Name}\"  address=185.51.200.2  index=2");

                        radRichTextEditorResult.Invoke((MethodInvoker)delegate
                        {
                            radRichTextEditorResult.AppendText(
                                "دی ان اس های شکن رایگان روی تمامی کارت شبکه های شما ست شد" + Environment.NewLine);
                            radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                            radRichTextEditorResult.ScrollToCaret();
                        });
                    }
                }
                else
                {
                    cmdHandelCommand(
                        $"netsh interface ipv4 add dnsservers    \"{nicList.Text}\"   address=178.22.122.100 index=1");
                    cmdHandelCommand(
                        $"netsh interface ipv4 add dnsservers    \"{nicList.Text}\"  address=185.51.200.2 index=2");

                    radRichTextEditorResult.Invoke((MethodInvoker)delegate
                    {
                        radRichTextEditorResult.AppendText("دی ان اس شکن رایگان روی کارت شبکه مورد نظر ست شد" +
                                                           Environment.NewLine);
                        radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                        radRichTextEditorResult.ScrollToCaret();
                    });
                }

                GlobalpUpdaterTimer.Instance.Stop();
                switchIPUpdater.Value = false;
            }
        }

        private void bg_IpUpdatre_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ShecanPro.Value)
            {
                #region ShecanProHTTPClient

                string url = "https://ddns.shecan.ir/update?password=" + UpdateIpPassword.Text;

                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(30); // Set the timeout before sending the request

                    // Add User-Agent header
                    Version version = Assembly.GetExecutingAssembly().GetName().Version!;
                    string user_agent = abdal_app_name + " " + version.Major + "." + version.Minor;
                    client.DefaultRequestHeaders.UserAgent.ParseAdd(user_agent);

                    try
                    {
                        HttpResponseMessage response = client.GetAsync(url).Result;
                        response.EnsureSuccessStatusCode();
                        ip_update_status = response.Content.ReadAsStringAsync().Result;
                    }
                    catch (Exception ex)
                    {
                        ip_update_status = "invalid";
                    }
                }


                if (ip_update_status == "invalid" || string.IsNullOrEmpty(ip_update_status))
                {
                    radRichTextEditorResult.Invoke((MethodInvoker)delegate
                    {
                        radRichTextEditorResult.AppendText("متأسفانه آی پی شما به شکن اعلام نشد" + Environment.NewLine);
                        radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                        radRichTextEditorResult.ScrollToCaret();
                    });
                }
                else
                {
                    radRichTextEditorResult.Invoke((MethodInvoker)delegate
                    {
                        radRichTextEditorResult.AppendText(" آی پی شما به شکن اعلام شد " +
                                                           DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " +
                                                           Environment.NewLine);
                        radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                        radRichTextEditorResult.ScrollToCaret();
                    });
                }

                #endregion
            }
        }

        private void ShowDeskAlert(string message, string sound)
        {
            desk_alert.CaptionText = "نرم افزار مدیریت شکن تیم ابدال";
            desk_alert.ContentText = message;
            desk_alert.Show();
            ab_player.sPlayerSync(sound);
        }

        private void bg_IpUpdatre_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (ShecanPro.Value)
                {
                    if (ip_update_status == "invalid" || string.IsNullOrEmpty(ip_update_status))
                    {
                        textUpdaterCodeStatus.Text = "وضعیت کد : نامعتبر";
                        textUpdaterCodeStatus.ForeColor = System.Drawing.Color.Crimson;
                    }
                    else
                    {
                        textUpdaterCodeStatus.Text = "وضعیت کد : معتبر";
                        textUpdaterCodeStatus.ForeColor = System.Drawing.Color.SpringGreen;
                    }
                }
            }
            catch (Exception ex)
            {

              // Do nothing
            }
        }

        public int GetIntervalFromForm()
        {
            TimeSpan selectedTimeSpan = (TimeSpan)TimeSpanPickerIpU.Value;
            int totalSeconds = (int)selectedTimeSpan.TotalSeconds;
            return totalSeconds;
        }
        private void IPUpdaterSwitch_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (switchIPUpdater.Value)
                {
                    ab_player.sPlayerSync("checkbox");

                    TimeSpanPickerIpU.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);

                    if (ShecanPro.Value == true)
                    {
                     

                        if (!GlobalpUpdaterTimer.Instance.IsRunning)
                        {
                            GlobalpUpdaterTimer.Instance.Start();
                        }
                    }
                    else
                    {
                        GlobalpUpdaterTimer.Instance.Stop();
                    }

                   
                }
                else
                {
                    ab_player.sPlayerSync("checkbox");
                    TimeSpanPickerIpU.BackColor = System.Drawing.Color.Crimson;
                   
                    GlobalpUpdaterTimer.Instance.Stop();

                }

                // Save To config file
                TimeSpan selectedTimeSpan = (TimeSpan)TimeSpanPickerIpU.Value;
                int seconds = selectedTimeSpan.Seconds;


                

                ShecanConfig.SaveConfig(
                    PubVar.configFilePath,
                    (ShecanPro.Value) ? "yes" : "no",
                    UpdateIpPassword.Text,
                    (switchIPUpdater.Value) ? "yes" : "no",
                    selectedTimeSpan.ToString()
                );
            }
            catch (Exception)
            {
                //Do nothing.
            }
        }

        private void ShecanPro_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ShecanPro.Value)
                {
                    ab_player.sPlayerSync("checkbox");
                    textUpdaterCodeStatus.Text = "وضعیت کد : نامشخص";
                    textUpdaterCodeStatus.ForeColor = System.Drawing.Color.FromArgb(221, 221, 221);

                    switchIPUpdater.Enabled = true;

                    GlobalpUpdaterTimer.Instance.Start();
                    TimeSpanPickerIpU.Enabled = true;
                    TimeSpanPickerIpU.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
                }
                else
                {
                    ab_player.sPlayerSync("checkbox");
                    textUpdaterCodeStatus.Text = "وضعیت کد : نامشخص";
                    textUpdaterCodeStatus.ForeColor = System.Drawing.Color.FromArgb(221, 221, 221);

                    switchIPUpdater.Enabled = false;
                    GlobalpUpdaterTimer.Instance.Stop();
                    TimeSpanPickerIpU.Enabled = false;
                    TimeSpanPickerIpU.BackColor = System.Drawing.Color.Crimson;
                }

                // Save To config file

                TimeSpan selectedTimeSpan = (TimeSpan)TimeSpanPickerIpU.Value;
                int seconds = selectedTimeSpan.Seconds;
                GlobalpUpdaterTimer.Instance.UpdateInterval(seconds * 1000);
                GlobalpUpdaterTimer.Instance.Start();


                ShecanConfig.SaveConfig(
                    PubVar.configFilePath,
                    (ShecanPro.Value) ? "yes" : "no",
                    UpdateIpPassword.Text,
                    (switchIPUpdater.Value) ? "yes" : "no",
                    selectedTimeSpan.ToString()
                );
            }
            catch (Exception)
            {
                //Do nothing.
            }
        }

        private void bg_auto_dns_DoWork(object sender, DoWorkEventArgs e)
        {
            switchIPUpdater.Value = false;
            GlobalpUpdaterTimer.Instance.Stop();
            // DHCP
            NetworkInterface[] interfaces_f1 = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces_f1)
            {
                cmdHandelCommand($"netsh interface ipv4 set dnsservers    \"{adapter.Name}\"  dhcp");
            }

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("دی ان اس سیستم شما بر روی حالت پیشفرض شبکه شما تغییر یافت." +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });


            // Clean DNS Cache
            cmdHandelCommand("ipconfig /flushdns");
            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("گش دی ان اس شما حذف شد" + Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });
            // Clean Route
            cmdHandelCommand(
                "for /f \"skip=3 tokens=4,6\" %e in ('netsh int ipv4 sh route store^=persistent ^| findstr -v 0.0.0.0/0') do route delete -4 -p %e %f");
            cmdHandelCommand(
                "for /f \"skip=3 tokens=4,6\" %e in ('netsh int ipv6 sh route store^=persistent ^| findstr -v ::/0') do route delete -6 -p %e %f");

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("کش روت های سیستم شما حذف شد تا شکن بدون اختلال کار کند" +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });


            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces)
            {
                cmdHandelCommand($"netsh interface ipv4 set dnsservers    \"{adapter.Name}\"  dhcp");
            }

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("دی ان اس سیستم شما بر روی حالت پیشفرض شبکه شما تغییر یافت." +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });
        }

        private void btn_set_dhcp_Click(object sender, EventArgs e)
        {
            if (bg_auto_dns.IsBusy != true)
            {
                bg_auto_dns.RunWorkerAsync();
            }
        }

        private void bgw_cloudflare_DoWork(object sender, DoWorkEventArgs e)
        {
            #region CFDns

            switchIPUpdater.Value = false;
            GlobalpUpdaterTimer.Instance.Stop();

            // DHCP
            NetworkInterface[] interfaces_f1 = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces_f1)
            {
                cmdHandelCommand($"netsh interface ipv4 set dnsservers    \"{adapter.Name}\"  dhcp");
            }

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("دی ان اس سیستم شما بر روی حالت پیشفرض شبکه شما تغییر یافت." +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });


            // Clean DNS Cache
            cmdHandelCommand("ipconfig /flushdns");
            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("گش دی ان اس شما حذف شد" + Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });
            // Clean Route
            cmdHandelCommand(
                "for /f \"skip=3 tokens=4,6\" %e in ('netsh int ipv4 sh route store^=persistent ^| findstr -v 0.0.0.0/0') do route delete -4 -p %e %f");
            cmdHandelCommand(
                "for /f \"skip=3 tokens=4,6\" %e in ('netsh int ipv6 sh route store^=persistent ^| findstr -v ::/0') do route delete -6 -p %e %f");

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("کش روت های سیستم شما حذف شد تا شکن بدون اختلال کار کند" +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });


            // Set CF DNS
            NetworkInterface[] interfaces_cf = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces_cf)
            {
                cmdHandelCommand(
                    $"netsh interface ipv4 add dnsservers    \"{adapter.Name}\"  address=1.1.1.1   index=1");
                cmdHandelCommand(
                    $"netsh interface ipv4 add dnsservers    \"{adapter.Name}\"  address=1.0.0.1   index=2");
            }

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("دی ان اس های کلودفلیر روی تمامی کارت شبکه های شما ست شد" +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });

            #endregion
        }

        private void tb_cf_g_dns_Click(object sender, EventArgs e)
        {
            if (bgw_cloudflare.IsBusy != true)
            {
                bgw_cloudflare.RunWorkerAsync();
            }
        }

        private void TimeSpanPickerIpU_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (GlobalpUpdaterTimer.Instance.IsRunning)
                {
                    GlobalpUpdaterTimer.Instance.UpdateInterval(GetIntervalFromForm() * 1000);
                }
                else
                {
                    GlobalpUpdaterTimer.Instance.UpdateInterval(GetIntervalFromForm() * 1000);
                    GlobalpUpdaterTimer.Instance.Stop();
                }
            }
            catch (Exception)
            {
                // Do nothing.
            }
            
        }

        private void bgw_cloudflare_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                ShowDeskAlert("توسط کاربر متوقف شد", "cancel");
            }
            else if (e.Error != null)
            {
                ShowDeskAlert(e.Error.Message, "error");
            }
            else
            {
                ShowDeskAlert("انجام شد", stop_op_status ? "cancel" : "cf-dns");
            }
        }

        private void bg_auto_dns_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                ShowDeskAlert("توسط کاربر متوقف شد", "cancel");
            }
            else if (e.Error != null)
            {
                ShowDeskAlert(e.Error.Message, "error");
            }
            else
            {
                ShowDeskAlert("انجام شد", stop_op_status ? "cancel" : "def-dns");
            }
        }

        private void bgw_google_DoWork(object sender, DoWorkEventArgs e)
        {
            switchIPUpdater.Value = false;
            GlobalpUpdaterTimer.Instance.Stop();
            // DHCP
            NetworkInterface[] interfaces_f1 = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces_f1)
            {
                cmdHandelCommand($"netsh interface ipv4 set dnsservers    \"{adapter.Name}\"  dhcp");
            }

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("دی ان اس سیستم شما بر روی حالت پیشفرض شبکه شما تغییر یافت." +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });


            // Clean DNS Cache
            cmdHandelCommand("ipconfig /flushdns");
            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("گش دی ان اس شما حذف شد" + Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });
            // Clean Route
            cmdHandelCommand(
                "for /f \"skip=3 tokens=4,6\" %e in ('netsh int ipv4 sh route store^=persistent ^| findstr -v 0.0.0.0/0') do route delete -4 -p %e %f");
            cmdHandelCommand(
                "for /f \"skip=3 tokens=4,6\" %e in ('netsh int ipv6 sh route store^=persistent ^| findstr -v ::/0') do route delete -6 -p %e %f");

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("کش روت های سیستم شما حذف شد تا شکن بدون اختلال کار کند" +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });


            // Set CF DNS
            NetworkInterface[] interfaces_cf = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces_cf)
            {
                cmdHandelCommand(
                    $"netsh interface ipv4 add dnsservers    \"{adapter.Name}\"  address=8.8.8.8   index=1");
                cmdHandelCommand(
                    $"netsh interface ipv4 add dnsservers    \"{adapter.Name}\"  address=8.8.4.4   index=2");
            }

            radRichTextEditorResult.Invoke((MethodInvoker)delegate
            {
                radRichTextEditorResult.AppendText("دی ان اس های گوگل روی تمامی کارت شبکه های شما ست شد" +
                                                   Environment.NewLine);
                radRichTextEditorResult.SelectionStart = radRichTextEditorResult.Text.Length;
                radRichTextEditorResult.ScrollToCaret();
            });
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (bgw_google.IsBusy != true)
            {
                bgw_google.RunWorkerAsync();
            }
        }

        private void bgw_google_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                ShowDeskAlert("توسط کاربر متوقف شد", "cancel");
            }
            else if (e.Error != null)
            {
                ShowDeskAlert(e.Error.Message, "error");
            }
            else
            {
                ShowDeskAlert("انجام شد", stop_op_status ? "cancel" : "google-dns");
            }
        }
    }
}