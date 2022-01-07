using QRCoder;
using System.Drawing;

namespace chestnut_qrcode
{
    /// <summary>
    /// 二维码编码器
    /// </summary>
    public static class Encoder
    {
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="msg">信息</param>
        /// <param name="version">版本 1 ~ 40</param>
        /// <param name="pixel">像素点大小</param>
        /// <param name="icon_path">图标路径</param>
        /// <param name="icon_size">图标尺寸</param>
        /// <param name="icon_border">图标边框厚度</param>
        /// <param name="white_edge">二维码白边</param>
        /// <returns>位图</returns>
        public static Bitmap code(string msg, int version, int pixel, string icon_path, int icon_size, int icon_border, bool white_edge)
        {

            QRCoder.QRCodeGenerator code_generator = new QRCoder.QRCodeGenerator();
           
            QRCoder.QRCodeData code_data = code_generator.CreateQrCode(msg, QRCoder.QRCodeGenerator.ECCLevel.M, true, true, QRCoder.QRCodeGenerator.EciMode.Utf8, version);

            QRCoder.QRCode code = new QRCoder.QRCode(code_data);

            Bitmap icon = new Bitmap(icon_path);

            Bitmap bmp = code.GetGraphic(pixel, Color.Black, Color.White, icon, icon_size, icon_border, white_edge);

            return bmp;
            //// 生成二维码的内容
            //QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode(msg, QRCodeGenerator.ECCLevel.Q);
            //QRCode qrcode = new QRCode(qrCodeData);
            ////中间小图图标
            //Bitmap icon = new Bitmap(@"D:\IISWeb\1.jpg");
            //// qrcode.GetGraphic 方法可参考最下发“补充说明” 30，代表像素
            //Bitmap qrCodeImage = qrcode.GetGraphic(30, Color.Black, Color.White, icon, 15, 6, false);

        }
    }
}
