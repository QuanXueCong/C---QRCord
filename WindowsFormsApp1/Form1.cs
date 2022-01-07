using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void baocun_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "(*.png)|*.png|(*.bmp)|*.bmp";

                    if (sfd.ShowDialog() == DialogResult.OK) pictureBox1.Image.Save(sfd.FileName);

                }
        }

        private void shengcheng_Click(object sender, EventArgs e)
        {
            int version = Convert.ToInt16(20);//版本

            int pixel = Convert.ToInt16(5);//像素

            string str_msg = GetString();//APN参数内容

            int int_icon_size = Convert.ToInt16(20);//二维码尺寸

            int int_icon_border = Convert.ToInt16(5);//

            bool b_we = true ;//是否 有白边

            Bitmap bmp = chestnut_qrcode.Encoder.code(str_msg, version, pixel, "C:/Users/chenz/Desktop/PElogo.png", int_icon_size, int_icon_border, b_we);

            pictureBox1.Image =  bmp;


        }

        /**
         * 封装填写的apn参数信息
         */
        private string GetString()
        {
            JObject jo = new JObject
            {
                { "name", name.Text },
                { "apn", apn.Text },
                { "proxy", proxy.Text },
                { "port", port.Text },
                { "user", user.Text },
                { "password", password.Text },
                { "server", server.Text },
                { "mmsc", mmsc.Text },
                { "mmsproxy", mmsproxy.Text },
                { "mmsport", mmsport.Text },
                { "mcc", mcc.Text },
                { "mnc", mnc.Text },
                { "authtype", authtype.SelectedIndex },
                { "type", type.Text },
                { "protocol", protocol.Text },
                { "roaming_protocol", roaming_protocol.Text }
            };

            return jo.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            name.Text = null;
            apn.Text = null;
            proxy.Text = null;
            port.Text = null;
            user.Text = null;
            password.Text = null;
            server.Text = null;
            mmsc.Text = null;
            mmsproxy.Text = null;
            mmsport.Text = null;
            mnc.Text = null;
            mcc.Text = null;
            authtype.SelectedIndex = 0;
            type.Text = null;
            protocol.SelectedIndex = 0;
            roaming_protocol.SelectedIndex = 0;
        }
    }
}
