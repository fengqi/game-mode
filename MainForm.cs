using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Threading;

namespace game_mode {
    public partial class GameMode : Form {
        private System.Configuration.Configuration config;

        public GameMode() {
            InitializeComponent();
        }

        private void GameMode_Load(object sender, EventArgs e) {
            log("启动软件");
            this.btn_disable.Enabled = false;

            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }

        private void GameMode_FormClosing(object sender, FormClosingEventArgs e) {
            log("退出，重置限速");
            this.setRTorrentSpeed(true);
            this.setTransmissionSpeed(true);
            Thread.Sleep(1000);
        }

        private void GameMode_ResizeBegin(object sender, EventArgs e) {
            return;
        }

        private void GameMode_SizeChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void btn_enable_Click(object sender, EventArgs e) {
            this.configLoad();
            log("开启游戏模式");
            
            this.setRTorrentSpeed(false);
            this.setTransmissionSpeed(false);

            this.btn_enable.Enabled = false;
            this.btn_disable.Enabled = true;
        }

        private void btn_disable_Click(object sender, EventArgs e) {
            log("关闭游戏模式");

            this.setRTorrentSpeed(true);
            this.setTransmissionSpeed(true);

            this.btn_enable.Enabled = true;
            this.btn_disable.Enabled = false;
        }

        private void log(string log) {
            log = DateTime.Now.ToString("HH:mm:ss") + " " + log + "\r\n";
            this.log_box.AppendText(log);
        }

        private void configLoad() {
            log("加载配置");
            string file = System.Windows.Forms.Application.ExecutablePath;
            config = ConfigurationManager.OpenExeConfiguration(file);
        }

        private void btn_setting_Click(object sender, EventArgs e) {
            Form set = new setting();
            set.Show();
        }

        private void setTransmissionSpeed(bool reset) {
            string host = config.AppSettings.Settings["tr_host"].Value;
            string user = config.AppSettings.Settings["tr_user"].Value;
            string pwd = config.AppSettings.Settings["tr_pwd"].Value;
            string speed_down = config.AppSettings.Settings["tr_speed_down"].Value;
            string speed_up = config.AppSettings.Settings["tr_speed_up"].Value;

            var values = new Dictionary<string, string>();
            var post = new FormUrlEncodedContent(values);

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", getBaiscAuthString(user, pwd));
            var response = client.PostAsync(host + "/transmission/rpc", post).Result;
            var contents = response.Content.ReadAsStringAsync().Result.ToString();

            var mc = Regex.Match(contents, @"<code>X-Transmission-Session-Id: (.*)<\/code>");
            if (mc.Groups.Count != 2) {
                log("验证失败");
                return;
            }
            var sessionId = mc.Groups[1].Value;

            string payload = String.Empty;
            if (reset) {
                payload = "{\"method\":\"session-set\",\"arguments\":{\"speed-limit-up-enabled\":false,\"speed-limit-down-enabled\":false}}";
            } else {
                payload = "{\"method\":\"session-set\",\"arguments\":{\"speed-limit-up-enabled\":true,\"speed-limit-down-enabled\":true,\"speed-limit-up\":"+speed_up+",\"speed-limit-down\":"+speed_down+"}}";
            }

            client.DefaultRequestHeaders.Add("X-Transmission-Session-Id", sessionId);
            var json = new StringContent(payload, Encoding.UTF8, "application/json");
            response = client.PostAsync(host + "/transmission/rpc", json).Result;
            contents = response.Content.ReadAsStringAsync().Result.ToString();
            if (contents.Contains("success")) {
                if (!reset) {
                    log(String.Format("TR 已限速: ↑{0}↓{1} KB/S", speed_up, speed_down));
                }
                else {
                    log(String.Format("TR 已限速: ↑{0}↓{1} KB/S", 0, 0));
                }
            } else {
                log("call tr err: " + contents);
            }
        }

        private void setRTorrentSpeed(bool reset) {
            string host = config.AppSettings.Settings["rt_host"].Value;
            string user = config.AppSettings.Settings["rt_user"].Value;
            string pwd = config.AppSettings.Settings["rt_pwd"].Value;
            string speed_down = config.AppSettings.Settings["rt_speed_down"].Value;
            string speed_up = config.AppSettings.Settings["rt_speed_up"].Value;

            int rate_down = 0;
            int rate_up = 0;
            string speed_rate_down = "0";
            string speed_rate_up = "0";
            if (!reset) {
                try {
                    rate_down = Int32.Parse(speed_down);
                    rate_up = Int32.Parse(speed_up);
                }
                catch (FormatException) {
                    log("输入的限速无效");
                }
                rate_down = rate_down * 1024;
                rate_up = rate_up * 1024;
                speed_rate_down = System.Convert.ToString(rate_down);
                speed_rate_up = System.Convert.ToString(rate_up);
            }

            var payload = String.Format("mode=setsettings&v={0}&v={1}&s=ndownload_rate&s=nupload_rate", speed_rate_down, speed_rate_up);
            var post = new StringContent(payload);

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", getBaiscAuthString(user, pwd));
            var response = client.PostAsync(host + "/plugins/httprpc/action.php", post).Result;
            var contents = response.Content.ReadAsStringAsync().Result.ToString();
            if (contents == "[\"0\",\"0\"]") {
                if (!reset) {
                    log(String.Format("RT 已限速: ↑{0}↓{1} KB/S", speed_up, speed_down));
                } else {
                    log(String.Format("RT 已限速: ↑{0}↓{1} KB/S", 0, 0));
                }
            }
            else {
                log("call rt err: " + contents);
            }
        }

        private string getBaiscAuthString(string user, string pwd) {
            var authenticationString = $"{user}:{pwd}";
            return Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                notifyIcon_MouseDoubleClick(sender, e);
            }
        }

        private void notifyMenu_Opening(object sender, CancelEventArgs e) {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
