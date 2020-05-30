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
            this.Gray.Location = new System.Drawing.Point(24, 78);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(114, 47);
            this.Gray.TabIndex = 1;
            this.Gray.Text = "灰階化";
            this.Gray.UseVisualStyleBackColor = false;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Invert
            // 
            this.Invert.Location = new System.Drawing.Point(43, 163);
            this.Invert.Name = "Invert";
            this.Invert.Size = new System.Drawing.Size(83, 36);
            this.Invert.TabIndex = 2;
            this.Invert.Text = "負片";
            this.Invert.UseVisualStyleBackColor = true;
            this.Invert.Click += new System.EventHandler(this.Invert_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(66, 228);
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
            this.Green.Location = new System.Drawing.Point(114, 228);
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
            this.Blue.Location = new System.Drawing.Point(12, 228);
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
            this.Light.Location = new System.Drawing.Point(12, 306);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(106, 47);
            this.Light.TabIndex = 6;
            this.Light.Text = "增加亮度";
            this.Light.UseVisualStyleBackColor = false;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 450);
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

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button Gray;
        private System.Windows.Forms.Button Invert;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Light;
    }
}

