
namespace game_mode {
    partial class setting {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tr_speed_down = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tr_speed_up = new System.Windows.Forms.TextBox();
            this.tr_speed_lab = new System.Windows.Forms.Label();
            this.tr_pwd_lab = new System.Windows.Forms.Label();
            this.tr_user_lab = new System.Windows.Forms.Label();
            this.tr_host_lab = new System.Windows.Forms.Label();
            this.tr_pwd = new System.Windows.Forms.TextBox();
            this.tr_user = new System.Windows.Forms.TextBox();
            this.tr_host = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rt_speed_down = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rt_speed_up = new System.Windows.Forms.TextBox();
            this.rt_speed_lab = new System.Windows.Forms.Label();
            this.rt_pwd = new System.Windows.Forms.TextBox();
            this.rt_user = new System.Windows.Forms.TextBox();
            this.rt_host = new System.Windows.Forms.TextBox();
            this.rt_pwd_lab = new System.Windows.Forms.Label();
            this.rt_user_lab = new System.Windows.Forms.Label();
            this.rt_host_lab = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tr_speed_down);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tr_speed_up);
            this.groupBox1.Controls.Add(this.tr_speed_lab);
            this.groupBox1.Controls.Add(this.tr_pwd_lab);
            this.groupBox1.Controls.Add(this.tr_user_lab);
            this.groupBox1.Controls.Add(this.tr_host_lab);
            this.groupBox1.Controls.Add(this.tr_pwd);
            this.groupBox1.Controls.Add(this.tr_user);
            this.groupBox1.Controls.Add(this.tr_host);
            this.groupBox1.Location = new System.Drawing.Point(37, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmission";
            // 
            // tr_speed_down
            // 
            this.tr_speed_down.Location = new System.Drawing.Point(112, 158);
            this.tr_speed_down.Name = "tr_speed_down";
            this.tr_speed_down.Size = new System.Drawing.Size(30, 21);
            this.tr_speed_down.TabIndex = 10;
            this.tr_speed_down.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speed_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "KB/S";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tr_speed_up
            // 
            this.tr_speed_up.Location = new System.Drawing.Point(76, 158);
            this.tr_speed_up.Name = "tr_speed_up";
            this.tr_speed_up.Size = new System.Drawing.Size(30, 21);
            this.tr_speed_up.TabIndex = 7;
            this.tr_speed_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speed_KeyPress);
            // 
            // tr_speed_lab
            // 
            this.tr_speed_lab.AutoSize = true;
            this.tr_speed_lab.Location = new System.Drawing.Point(13, 168);
            this.tr_speed_lab.Name = "tr_speed_lab";
            this.tr_speed_lab.Size = new System.Drawing.Size(29, 12);
            this.tr_speed_lab.TabIndex = 6;
            this.tr_speed_lab.Text = "限速";
            // 
            // tr_pwd_lab
            // 
            this.tr_pwd_lab.AutoSize = true;
            this.tr_pwd_lab.Location = new System.Drawing.Point(11, 125);
            this.tr_pwd_lab.Name = "tr_pwd_lab";
            this.tr_pwd_lab.Size = new System.Drawing.Size(29, 12);
            this.tr_pwd_lab.TabIndex = 5;
            this.tr_pwd_lab.Text = "密码";
            // 
            // tr_user_lab
            // 
            this.tr_user_lab.AutoSize = true;
            this.tr_user_lab.Location = new System.Drawing.Point(9, 76);
            this.tr_user_lab.Name = "tr_user_lab";
            this.tr_user_lab.Size = new System.Drawing.Size(41, 12);
            this.tr_user_lab.TabIndex = 4;
            this.tr_user_lab.Text = "用户名";
            // 
            // tr_host_lab
            // 
            this.tr_host_lab.AutoSize = true;
            this.tr_host_lab.Location = new System.Drawing.Point(7, 32);
            this.tr_host_lab.Name = "tr_host_lab";
            this.tr_host_lab.Size = new System.Drawing.Size(29, 12);
            this.tr_host_lab.TabIndex = 3;
            this.tr_host_lab.Text = "地址";
            // 
            // tr_pwd
            // 
            this.tr_pwd.Location = new System.Drawing.Point(76, 116);
            this.tr_pwd.Name = "tr_pwd";
            this.tr_pwd.Size = new System.Drawing.Size(100, 21);
            this.tr_pwd.TabIndex = 2;
            this.tr_pwd.UseSystemPasswordChar = true;
            // 
            // tr_user
            // 
            this.tr_user.Location = new System.Drawing.Point(76, 76);
            this.tr_user.Name = "tr_user";
            this.tr_user.Size = new System.Drawing.Size(100, 21);
            this.tr_user.TabIndex = 1;
            // 
            // tr_host
            // 
            this.tr_host.Location = new System.Drawing.Point(76, 32);
            this.tr_host.Name = "tr_host";
            this.tr_host.Size = new System.Drawing.Size(100, 21);
            this.tr_host.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rt_speed_down);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rt_speed_up);
            this.groupBox2.Controls.Add(this.rt_speed_lab);
            this.groupBox2.Controls.Add(this.rt_pwd);
            this.groupBox2.Controls.Add(this.rt_user);
            this.groupBox2.Controls.Add(this.rt_host);
            this.groupBox2.Controls.Add(this.rt_pwd_lab);
            this.groupBox2.Controls.Add(this.rt_user_lab);
            this.groupBox2.Controls.Add(this.rt_host_lab);
            this.groupBox2.Location = new System.Drawing.Point(243, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "rTorrent";
            // 
            // rt_speed_down
            // 
            this.rt_speed_down.Location = new System.Drawing.Point(116, 158);
            this.rt_speed_down.Name = "rt_speed_down";
            this.rt_speed_down.Size = new System.Drawing.Size(30, 21);
            this.rt_speed_down.TabIndex = 10;
            this.rt_speed_down.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speed_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "KB/S";
            // 
            // rt_speed_up
            // 
            this.rt_speed_up.Location = new System.Drawing.Point(80, 159);
            this.rt_speed_up.Name = "rt_speed_up";
            this.rt_speed_up.Size = new System.Drawing.Size(30, 21);
            this.rt_speed_up.TabIndex = 7;
            this.rt_speed_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speed_KeyPress);
            // 
            // rt_speed_lab
            // 
            this.rt_speed_lab.AutoSize = true;
            this.rt_speed_lab.Location = new System.Drawing.Point(27, 168);
            this.rt_speed_lab.Name = "rt_speed_lab";
            this.rt_speed_lab.Size = new System.Drawing.Size(29, 12);
            this.rt_speed_lab.TabIndex = 6;
            this.rt_speed_lab.Text = "限速";
            // 
            // rt_pwd
            // 
            this.rt_pwd.Location = new System.Drawing.Point(80, 116);
            this.rt_pwd.Name = "rt_pwd";
            this.rt_pwd.Size = new System.Drawing.Size(100, 21);
            this.rt_pwd.TabIndex = 5;
            this.rt_pwd.UseSystemPasswordChar = true;
            // 
            // rt_user
            // 
            this.rt_user.Location = new System.Drawing.Point(80, 75);
            this.rt_user.Name = "rt_user";
            this.rt_user.Size = new System.Drawing.Size(100, 21);
            this.rt_user.TabIndex = 4;
            // 
            // rt_host
            // 
            this.rt_host.Location = new System.Drawing.Point(80, 32);
            this.rt_host.Name = "rt_host";
            this.rt_host.Size = new System.Drawing.Size(100, 21);
            this.rt_host.TabIndex = 3;
            // 
            // rt_pwd_lab
            // 
            this.rt_pwd_lab.AutoSize = true;
            this.rt_pwd_lab.Location = new System.Drawing.Point(25, 125);
            this.rt_pwd_lab.Name = "rt_pwd_lab";
            this.rt_pwd_lab.Size = new System.Drawing.Size(29, 12);
            this.rt_pwd_lab.TabIndex = 2;
            this.rt_pwd_lab.Text = "密码";
            // 
            // rt_user_lab
            // 
            this.rt_user_lab.AutoSize = true;
            this.rt_user_lab.Location = new System.Drawing.Point(25, 76);
            this.rt_user_lab.Name = "rt_user_lab";
            this.rt_user_lab.Size = new System.Drawing.Size(41, 12);
            this.rt_user_lab.TabIndex = 1;
            this.rt_user_lab.Text = "用户名";
            // 
            // rt_host_lab
            // 
            this.rt_host_lab.AutoSize = true;
            this.rt_host_lab.Location = new System.Drawing.Point(25, 32);
            this.rt_host_lab.Name = "rt_host_lab";
            this.rt_host_lab.Size = new System.Drawing.Size(29, 12);
            this.rt_host_lab.TabIndex = 0;
            this.rt_host_lab.Text = "地址";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(162, 232);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(243, 232);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 267);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "setting";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tr_host_lab;
        private System.Windows.Forms.TextBox tr_pwd;
        private System.Windows.Forms.TextBox tr_user;
        private System.Windows.Forms.TextBox tr_host;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tr_pwd_lab;
        private System.Windows.Forms.Label tr_user_lab;
        private System.Windows.Forms.TextBox rt_pwd;
        private System.Windows.Forms.TextBox rt_user;
        private System.Windows.Forms.TextBox rt_host;
        private System.Windows.Forms.Label rt_pwd_lab;
        private System.Windows.Forms.Label rt_user_lab;
        private System.Windows.Forms.Label rt_host_lab;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tr_speed_up;
        private System.Windows.Forms.Label tr_speed_lab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rt_speed_up;
        private System.Windows.Forms.Label rt_speed_lab;
        private System.Windows.Forms.TextBox tr_speed_down;
        private System.Windows.Forms.TextBox rt_speed_down;
    }
}