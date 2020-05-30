﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Img
{
    public partial class Form1 : Form
    {
        ImageForm CurrentImage = null;
        public Form1()
        {
            InitializeComponent();
        }



        // ==================================   使用者介面相關   =====================================
        // Load 按鈕事件處理函式
        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\a3344\Desktop\Img";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageForm MyImage = new ImageForm(openFileDialog1.FileName); // 建立秀圖物件
                
                MyImage.Show(); // 顯示秀圖照片
                CurrentImage = MyImage;

            }

        }

        private void Gray_Click(object sender, EventArgs e)
        {
            if(CurrentImage != null)
            {
                int[,,] rgbData = CurrentImage.getRGBData();                
                CurrentImage.doGray(rgbData);
               
            }
            else
            {
                MessageBox.Show("請先載入圖形");
            }
        }

        private void Invert_Click(object sender, EventArgs e)
        {
            if(CurrentImage != null)
            {
                CurrentImage.Invert();
            }
            else
            {
                MessageBox.Show("請先載入圖形");
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {

            if (CurrentImage != null)
            {
                ColoFilter(0);
            }
            else
            {
                MessageBox.Show("請先載入圖形");
            }
        }

        private void Green_Click(object sender, EventArgs e)
        {

            if (CurrentImage != null)
            {
                ColoFilter(1);
            }
            else
            {
                MessageBox.Show("請先載入圖形");
            }
        }

        private void Blue_Click(object sender, EventArgs e)
        {

            if (CurrentImage != null)
            {
                ColoFilter(2);
            }
            else
            {
                MessageBox.Show("請先載入圖形");
            }
        }


        // ==================================   影像處理公用程式相關   =====================================
        public void ColoFilter(int select)
        {
            // Step 1: 取出顏色資料
            int[,,] rgbData = CurrentImage.getRGBData_unsafe();

            // Step 2: 數位影像處理
            //  將所有顏色 Channel 資料改成 0, 只留下紅色區域
            int Width = rgbData.GetLength(0);
            int Height = rgbData.GetLength(1);

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    switch (select)
                    {
                        case 0: // 執行紅色濾鏡功能
                            rgbData[x, y, 1] = 0; // Green Channel 改成 0
                            rgbData[x, y, 2] = 0; // Blue Channel 改成 0
                            break;
                        case 1: // 執行綠色 filter 功能
                            rgbData[x, y, 0] = 0; // Red Channel 改成 0
                            rgbData[x, y, 2] = 0; // Blue Channel 改成 0
                            break;
                        case 2: // 執行藍色濾鏡的功能
                            rgbData[x, y, 0] = 0; // Red Channel 改成 0
                            rgbData[x, y, 1] = 0; // Blue Channel 改成 0
                            break;
                        default:
                            break;
                    }
                }
            }

            // Step 3: 將處理後的資料寫回 CurrentImage
            CurrentImage.setRGBData_unsafe(rgbData);
        }



    }
}
