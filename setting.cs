using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace game_mode {
    public partial class setting : Form {
        private System.Configuration.Configuration config;

        public setting() {
            InitializeComponent();
            this.configLoad();
        }

        private void setting_Load(object sender, EventArgs e) {
            
            this.Hide();

            if (config.AppSettings.Settings["tr_host"] != null) {
                tr_host.Text = config.AppSettings.Settings["tr_host"].Value;
            } else {
                config.AppSettings.Settings.Add("tr_host", "");
            }

            if (config.AppSettings.Settings["tr_user"] != null) {
                tr_user.Text = config.AppSettings.Settings["tr_user"].Value;
            } else {
                config.AppSettings.Settings.Add("tr_user", "");
            }

            if (config.AppSettings.Settings["tr_pwd"] != null) {
                tr_pwd.Text = config.AppSettings.Settings["tr_pwd"].Value;
            } else {
                config.AppSettings.Settings.Add("tr_pwd", "");
            }

            if (config.AppSettings.Settings["tr_speed_up"] != null) {
                tr_speed_up.Text = config.AppSettings.Settings["tr_speed_up"].Value;
            }
            else {
                config.AppSettings.Settings.Add("tr_speed_up", "");
            }

            if (config.AppSettings.Settings["tr_speed_down"] != null) {
                tr_speed_down.Text = config.AppSettings.Settings["tr_speed_down"].Value;
            }
            else {
                config.AppSettings.Settings.Add("tr_speed_down", "");
            }

            if (config.AppSettings.Settings["rt_host"] != null) {
                rt_host.Text = config.AppSettings.Settings["rt_host"].Value;
            }
            else {
                config.AppSettings.Settings.Add("rt_host", "");
            }

            if (config.AppSettings.Settings["rt_user"] != null) {
                rt_user.Text = config.AppSettings.Settings["rt_user"].Value;
            }
            else {
                config.AppSettings.Settings.Add("rt_user", "");
            }

            if (config.AppSettings.Settings["rt_pwd"] != null) {
                rt_pwd.Text = config.AppSettings.Settings["rt_pwd"].Value;
            }
            else {
                config.AppSettings.Settings.Add("rt_pwd", "");
            }

            if (config.AppSettings.Settings["rt_speed_up"] != null) {
                rt_speed_up.Text = config.AppSettings.Settings["rt_speed_up"].Value;
            }
            else {
                config.AppSettings.Settings.Add("rt_speed_up", "");
            }

            if (config.AppSettings.Settings["rt_speed_down"] != null) {
                rt_speed_down.Text = config.AppSettings.Settings["rt_speed_down"].Value;
            }
            else {
                config.AppSettings.Settings.Add("rt_speed_down", "");
            }
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            config.AppSettings.Settings["tr_host"].Value = tr_host.Text;
            config.AppSettings.Settings["tr_user"].Value = tr_user.Text;
            config.AppSettings.Settings["tr_pwd"].Value = tr_pwd.Text;
            config.AppSettings.Settings["tr_speed_down"].Value = tr_speed_up.Text;
            config.AppSettings.Settings["tr_speed_up"].Value = tr_speed_down.Text;
            config.AppSettings.Settings["rt_host"].Value = rt_host.Text;
            config.AppSettings.Settings["rt_user"].Value = rt_user.Text;
            config.AppSettings.Settings["rt_pwd"].Value = rt_pwd.Text;
            config.AppSettings.Settings["rt_speed_down"].Value = rt_speed_up.Text;
            config.AppSettings.Settings["rt_speed_up"].Value = rt_speed_down.Text;
            config.Save();
            this.configLoad();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void configLoad() {
            string file = System.Windows.Forms.Application.ExecutablePath;
            config = ConfigurationManager.OpenExeConfiguration(file);
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void speed_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
            if ((e.KeyChar >= 47 && e.KeyChar <= 58) || e.KeyChar == 8) {
                e.Handled = false;
            }
            if (e.KeyChar == 46) {
                if (this.Text.Length <= 0) {
                    e.Handled = true;
                }
                else {
                    float f;
                    if (float.TryParse(this.Text + e.KeyChar.ToString(), out f)) {
                        e.Handled = false;
                    }
                }
            }
        }
    }
}
