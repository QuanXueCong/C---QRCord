
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.proxy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mmsc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mnc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mcc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mmsport = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mmsproxy = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shengcheng = new System.Windows.Forms.Button();
            this.baocun = new System.Windows.Forms.Button();
            this.authtype = new System.Windows.Forms.ComboBox();
            this.roaming_protocol = new System.Windows.Forms.ComboBox();
            this.protocol = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(106, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 21);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "APN：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // apn
            // 
            this.apn.Location = new System.Drawing.Point(106, 50);
            this.apn.Name = "apn";
            this.apn.Size = new System.Drawing.Size(150, 21);
            this.apn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "端口：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(106, 100);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(150, 21);
            this.port.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(40, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "代理：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // proxy
            // 
            this.proxy.Location = new System.Drawing.Point(106, 75);
            this.proxy.Name = "proxy";
            this.proxy.Size = new System.Drawing.Size(150, 21);
            this.proxy.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(40, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "MMSC：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mmsc
            // 
            this.mmsc.Location = new System.Drawing.Point(106, 200);
            this.mmsc.Name = "mmsc";
            this.mmsc.Size = new System.Drawing.Size(150, 21);
            this.mmsc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(40, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "服务器：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(106, 175);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(150, 21);
            this.server.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(40, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "密码：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(106, 150);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(150, 21);
            this.password.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label8.Location = new System.Drawing.Point(40, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "用户名：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(106, 125);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(150, 21);
            this.user.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label9.Location = new System.Drawing.Point(12, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "APN漫游协议：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label10.Location = new System.Drawing.Point(40, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "APN协议：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label11.Location = new System.Drawing.Point(40, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "APN类型：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(106, 350);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(150, 21);
            this.type.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.Location = new System.Drawing.Point(8, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "身份验证类型：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label13.Location = new System.Drawing.Point(40, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "MNC：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnc
            // 
            this.mnc.Location = new System.Drawing.Point(106, 300);
            this.mnc.Name = "mnc";
            this.mnc.Size = new System.Drawing.Size(150, 21);
            this.mnc.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(40, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "MCC：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mcc
            // 
            this.mcc.Location = new System.Drawing.Point(106, 275);
            this.mcc.Name = "mcc";
            this.mcc.Size = new System.Drawing.Size(150, 21);
            this.mcc.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label15.Location = new System.Drawing.Point(26, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 21);
            this.label15.TabIndex = 19;
            this.label15.Text = "彩信端口：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mmsport
            // 
            this.mmsport.Location = new System.Drawing.Point(106, 250);
            this.mmsport.Name = "mmsport";
            this.mmsport.Size = new System.Drawing.Size(150, 21);
            this.mmsport.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label16.Location = new System.Drawing.Point(24, 225);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(76, 21);
            this.label16.TabIndex = 17;
            this.label16.Text = "彩信代理：";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mmsproxy
            // 
            this.mmsproxy.Location = new System.Drawing.Point(106, 225);
            this.mmsproxy.Name = "mmsproxy";
            this.mmsproxy.Size = new System.Drawing.Size(150, 21);
            this.mmsproxy.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(310, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // shengcheng
            // 
            this.shengcheng.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.shengcheng.Location = new System.Drawing.Point(397, 445);
            this.shengcheng.Name = "shengcheng";
            this.shengcheng.Size = new System.Drawing.Size(81, 32);
            this.shengcheng.TabIndex = 39;
            this.shengcheng.Text = "生成";
            this.shengcheng.UseVisualStyleBackColor = true;
            this.shengcheng.Click += new System.EventHandler(this.shengcheng_Click);
            // 
            // baocun
            // 
            this.baocun.Location = new System.Drawing.Point(520, 445);
            this.baocun.Name = "baocun";
            this.baocun.Size = new System.Drawing.Size(81, 32);
            this.baocun.TabIndex = 40;
            this.baocun.Text = "保存";
            this.baocun.UseVisualStyleBackColor = true;
            this.baocun.Click += new System.EventHandler(this.baocun_Click);
            // 
            // authtype
            // 
            this.authtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authtype.FormattingEnabled = true;
            this.authtype.Items.AddRange(new object[] {
            "无",
            "PAP",
            "CHAP",
            "PAP或CHAP"});
            this.authtype.Location = new System.Drawing.Point(106, 325);
            this.authtype.Name = "authtype";
            this.authtype.Size = new System.Drawing.Size(150, 20);
            this.authtype.TabIndex = 41;
            this.authtype.SelectedIndex = 0;
            // 
            // roaming_protocol
            // 
            this.roaming_protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roaming_protocol.FormattingEnabled = true;
            this.roaming_protocol.Items.AddRange(new object[] {
            "IPV4",
            "IPV6",
            "IPV4V6"});
            this.roaming_protocol.Location = new System.Drawing.Point(106, 400);
            this.roaming_protocol.Name = "roaming_protocol";
            this.roaming_protocol.Size = new System.Drawing.Size(150, 20);
            this.roaming_protocol.TabIndex = 42;
            this.roaming_protocol.SelectedIndex = 0;
            // 
            // protocol
            // 
            this.protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protocol.FormattingEnabled = true;
            this.protocol.Items.AddRange(new object[] {
            "IPV4",
            "IPV6",
            "IPV4V6"});
            this.protocol.Location = new System.Drawing.Point(106, 375);
            this.protocol.Name = "protocol";
            this.protocol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.protocol.Size = new System.Drawing.Size(150, 20);
            this.protocol.TabIndex = 43;
            this.protocol.SelectedIndex = 0;
            // 
            // reset
            // 
            this.reset.Cursor = System.Windows.Forms.Cursors.Default;
            this.reset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.reset.Location = new System.Drawing.Point(106, 445);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(81, 32);
            this.reset.TabIndex = 44;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 501);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.protocol);
            this.Controls.Add(this.roaming_protocol);
            this.Controls.Add(this.authtype);
            this.Controls.Add(this.baocun);
            this.Controls.Add(this.shengcheng);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mnc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mcc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.mmsport);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mmsproxy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mmsc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proxy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JY_APN二维码生成工具";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox proxy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mmsc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mnc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox mcc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox mmsport;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox mmsproxy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button shengcheng;
        private System.Windows.Forms.Button baocun;
        private System.Windows.Forms.ComboBox roaming_protocol;
        private System.Windows.Forms.ComboBox protocol;
        private System.Windows.Forms.Button reset;
        protected System.Windows.Forms.ComboBox authtype;
    }
}

