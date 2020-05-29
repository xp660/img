using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Img
{
    public partial class ImageForm : Form
    {
        Image image;
        
        public ImageForm()
        {
            // Step 1: 載入影像  
            LoadImage("空中花園.jpg");
        }

        public ImageForm(String FileName)
        {
            LoadImage(FileName);
        }

        public void LoadImage(String FileName)
        {
            // Step 1: 載入影像 
            image = Image.FromFile(FileName);
            this.Text = FileName;

            // Step 2: 調整視窗的大小
            this.Height = image.Height;
            this.Width = image.Width;
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            // Step 3: 顯示出影像
            // e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);

            //int cx = ClientSize.Width;
            //int cy = ClientSize.Height;


            // 放大 2 倍
            this.Height = image.Height * 2;
            this.Width = image.Width * 2;

            e.Graphics.DrawImage(image, new Point[] { new Point(0, 0) ,
                                        new Point(2*image.Width, 0),
                                        new Point(0, 2*image.Height) });

            /*
            // 縮小 1/2 倍            
            e.Graphics.DrawImage(image, new Point[] { new Point(0, 0) ,
                                        new Point(image.Width/2, 0),
                                        new Point(0, image.Height/2) });
             */

            /*
            // 形變旋轉
            e.Graphics.DrawImage(image, new Point[] { new Point(cx/2, 0) ,
                                        new Point(cx, cy/2),
                                        new Point(0, cy/2) });
            */
            image.Save(@"C:\Users\a3344\Desktop\Img/image.bmp", ImageFormat.Bmp);
            image.Save(@"C:\Users\a3344\Desktop\Img/image.Gif");
        }

        public int[,,] getRGBData()
        {
            MessageBox.Show("開始RGB彩色資訊讀取");
            //step 1: 利用Bitmap將image包起來
            Bitmap bimage = new Bitmap(image);
            int Height = bimage.Height;
            int Width = bimage.Width;
            int[,,] rgbData = new int[Width, Height, 3];
            
            //step 2: 取得像點顏色資訊
            for(int y = 0; y < Height; y++)
            {
                for(int x = 0; x < Width; x++)
                {
                    Color color = bimage.GetPixel(x, y);
                    rgbData[x, y, 0] = color.R;
                    rgbData[x, y, 1] = color.G;
                    rgbData[x, y, 2] = color.B;
                }
            }

            MessageBox.Show("RGB顏色資訊讀取完成");
            return rgbData;
        }

        public void doGray(int[,,] rgbData)
        {
            MessageBox.Show("開始進行灰階處理");
            Bitmap bimage = new Bitmap(image);
            int Height = bimage.Height;
            int Width = bimage.Width;

            for(int y = 0; y < Height; y++)
            {
                for(int x = 0; x < Width; x++)
                {
                    int gray = (rgbData[x, y, 0] + rgbData[x, y, 1] + rgbData[x, y, 2]) / 3;
                    bimage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            image = bimage;
            this.Refresh();
            MessageBox.Show("灰階處理完成");
        }


    }
}
