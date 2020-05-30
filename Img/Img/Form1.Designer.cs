namespace Img
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.load = new System.Windows.Forms.Button();
            this.Gray = new System.Windows.Forms.Button();
            this.Invert = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Light = new System.Windows.Forms.Button();
            this.dark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 396);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(114, 42);
            this.load.TabIndex = 0;
            this.load.Text = "載入圖片";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Gray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gray.Location = new System.Drawing.Point(12, 22);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(114, 47);
            this.Gray.TabIndex = 1;
            this.Gray.Text = "灰階化";
            this.Gray.UseVisualStyleBackColor = false;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Invert
            // 
            this.Invert.Location = new System.Drawing.Point(12, 87);
            this.Invert.Name = "Invert";
            this.Invert.Size = new System.Drawing.Size(114, 36);
            this.Invert.TabIndex = 2;
            this.Invert.Text = "負片";
            this.Invert.UseVisualStyleBackColor = true;
            this.Invert.Click += new System.EventHandler(this.Invert_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(62, 210);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(42, 41);
            this.Red.TabIndex = 3;
            this.Red.Text = "紅色濾鏡";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green.Location = new System.Drawing.Point(110, 210);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(38, 41);
            this.Green.TabIndex = 4;
            this.Green.Text = "綠色濾鏡";
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.SystemColors.Highlight;
            this.Blue.Location = new System.Drawing.Point(8, 210);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(48, 41);
            this.Blue.TabIndex = 5;
            this.Blue.Text = "藍色濾鏡";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Light
            // 
            this.Light.BackColor = System.Drawing.Color.White;
            this.Light.Location = new System.Drawing.Point(98, 311);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(36, 22);
            this.Light.TabIndex = 6;
            this.Light.Text = "+";
            this.Light.UseVisualStyleBackColor = false;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // dark
            // 
            this.dark.BackColor = System.Drawing.Color.White;
            this.dark.Location = new System.Drawing.Point(50, 311);
            this.dark.Name = "dark";
            this.dark.Size = new System.Drawing.Size(36, 23);
            this.dark.TabIndex = 7;
            this.dark.Text = "-";
            this.dark.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "亮度大小:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "濾鏡效果:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dark);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Invert);
            this.Controls.Add(this.Gray);
            this.Controls.Add(this.load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button Gray;
        private System.Windows.Forms.Button Invert;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Light;
        private System.Windows.Forms.Button dark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

