using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ResizeImagesCordova
{
    public partial class Form1 : Form
    {
        Image _image;

        public Form1()
        {
            InitializeComponent();

            ofd_Image.Filter = "";

            var codecs = ImageCodecInfo.GetImageEncoders();
            var sep = string.Empty;

            foreach (var c in codecs)
            {
                var codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                ofd_Image.Filter = string.Format("{0}{1}{2} ({3})|{3}", ofd_Image.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }

            ofd_Image.Filter = string.Format("{0}{1}{2} ({3})|{3}", ofd_Image.Filter, sep, "All Files", "*.*");

            ofd_Image.DefaultExt = ".png"; // Default file extension 
        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            var dr = ofd_Image.ShowDialog();
            if (dr != DialogResult.OK) return;
            try
            {
                _image = Image.FromFile(ofd_Image.FileName);
            }
            catch
            {
                MessageBox.Show("Please choose an image!");
                return;
            }
            pb_Image.Image = _image;
            btn_Create.Enabled = true;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            btn_Create.Enabled = false;

            if (rb_Icons.Checked)
            {
                if (Directory.Exists("icons"))
                    Directory.Delete("icons", true);
                Directory.CreateDirectory("icons");
                Directory.CreateDirectory("icons/android");
                Directory.CreateDirectory("icons/ios");
                Directory.CreateDirectory("icons/windows");
                Directory.CreateDirectory("icons/wp8");

                var iconDimensions = new Dictionary<string, Size>
                {
                    {"drawable-ldpi-icon", new Size(36, 36)},//android
                    {"drawable-mdpi-icon", new Size(48, 48)},
                    {"drawable-hdpi-icon", new Size(72, 72)},
                    {"drawable-xhdpi-icon", new Size(96, 96)},
                    {"drawable-xxhdpi-icon", new Size(144, 144)},
                    {"drawable-xxxhdpi-icon", new Size(192, 192)},
                    {"icon-small", new Size(29, 29)},//ios
                    {"icon-40", new Size(40, 40)},
                    {"icon-50", new Size(50, 50)},
                    {"icon-57", new Size(57, 57)},
                    {"icon-small-2x", new Size(58, 58)},
                    {"icon-60", new Size(60, 60)},
                    {"icon-72", new Size(72, 72)},
                    {"icon-76", new Size(76, 76)},
                    {"icon-40-2x", new Size(80, 80)},
                    {"icon-50-2x", new Size(100, 100)},
                    {"icon-57-2x", new Size(114, 114)},
                    {"icon-60-2x", new Size(120, 120)},
                    {"icon-72-2x", new Size(144, 144)},
                    {"icon-76-2x", new Size(152, 152)},
                    {"icon-60-3x", new Size(180, 180)},
                    {"smalllogo", new Size(30, 30)},//windows
                    {"storelogo", new Size(50, 50)},
                    {"logo", new Size(150, 150)},
                    {"icon-62-tile", new Size(62, 62)},//wp8
                    {"icon-173-tile", new Size(173, 173)}
                };

                foreach (var dimension in iconDimensions)
                {
                    var imagePath = "";
                    if (dimension.Key.StartsWith("draw"))
                        imagePath = "icons/android/";
                    else if (dimension.Key.EndsWith("logo"))
                        imagePath = "icons/windows/";
                    else if (dimension.Key.EndsWith("tile"))
                        imagePath = "icons/wp8/";
                    else if (dimension.Key.StartsWith("icon"))
                        imagePath = "icons/ios/";

                    Image imgGdi = ResizeImage(_image, dimension.Value.Width, dimension.Value.Height);
                    imgGdi.Save(imagePath + dimension.Key + ".png", ImageFormat.Png);
                }
                MessageBox.Show("Icons successfully created!");
                btn_Create.Enabled = true;
            }
            else if (rb_ScreensPortrait.Checked)
            {
                if (Directory.Exists("screens"))
                    Directory.Delete("screens", true);
                Directory.CreateDirectory("screens");
                Directory.CreateDirectory("screens/android");
                Directory.CreateDirectory("screens/ios");
                Directory.CreateDirectory("screens/windows");
                Directory.CreateDirectory("screens/wp8");

                var screenDimensions = new Dictionary<string, Size>
                {
                    {"drawable-port-hdpi-screen", new Size(480, 800)}, //android
                    {"drawable-port-ldpi-screen", new Size(240, 320)},
                    {"drawable-port-mdpi-screen", new Size(320, 480)},
                    {"drawable-port-xhdpi-screen", new Size(720, 1280)},
                    {"drawable-port-xxhdpi-screen", new Size(960, 1600)},
                    {"screen-ipad-portrait", new Size(768, 1024)}, //ios
                    {"screen-iphone-568h-2x", new Size(640, 1136)},
                    {"screen-iphone-portrait", new Size(320, 480)},
                    {"screen-iphone-portrait-2x", new Size(640, 960)},
                    {"screen-portrait", new Size(480, 800)}, //wp8
                };

                foreach (var dimension in screenDimensions)
                {
                    var imagePath = "";
                    if (dimension.Key.StartsWith("draw"))
                        imagePath = "screens/android/";
                    else if (dimension.Key == "screen-portrait")
                        imagePath = "screens/wp8/";
                    else if (dimension.Key.StartsWith("screen"))
                        imagePath = "screens/ios/";

                    Image imgGdi = ResizeImage(_image, dimension.Value.Width, dimension.Value.Height);
                    imgGdi.Save(imagePath + dimension.Key + ".png", ImageFormat.Png);
                }
                MessageBox.Show("Portrait screens successfully created!");
                btn_Create.Enabled = true;
            }
            else
            {
                if (Directory.Exists("screens"))
                    Directory.Delete("screens", true);
                Directory.CreateDirectory("screens");
                Directory.CreateDirectory("screens/android");
                Directory.CreateDirectory("screens/ios");
                Directory.CreateDirectory("screens/windows");
                Directory.CreateDirectory("screens/wp8");

                var screenDimensions = new Dictionary<string, Size>
                {
                    {"drawable-land-hdpi-screen", new Size(800, 480)}, //android
                    {"drawable-land-ldpi-screen", new Size(320, 240)},
                    {"drawable-land-mdpi-screen", new Size(480, 320)},
                    {"screen-ipad-landscape", new Size(1024, 768)}, //ios
                    {"screen-ipad-landscape-2x", new Size(2048, 1536)},
                    {"splashscreen", new Size(620, 300)}, //windows
                };

                foreach (var dimension in screenDimensions)
                {
                    var imagePath = "";
                    if (dimension.Key.StartsWith("draw"))
                        imagePath = "screens/android/";
                    else if (dimension.Key == "splashscreen")
                        imagePath = "screens/windows/";
                    else if (dimension.Key.StartsWith("screen"))
                        imagePath = "screens/ios/";

                    Image imgGdi = ResizeImage(_image, dimension.Value.Width, dimension.Value.Height);
                    imgGdi.Save(imagePath + dimension.Key + ".png", ImageFormat.Png);
                }
                MessageBox.Show("Landscape screens successfully created!");
                btn_Create.Enabled = true;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
