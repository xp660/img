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




    }
}
