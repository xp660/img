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
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 391);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(127, 47);
            this.load.TabIndex = 0;
            this.load.Text = "載入圖片";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Gray
            // 
            this.Gray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gray.Location = new System.Drawing.Point(469, 391);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(109, 47);
            this.Gray.TabIndex = 1;
            this.Gray.Text = "灰階化";
            this.Gray.UseVisualStyleBackColor = true;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gray);
            this.Controls.Add(this.load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button Gray;
    }
}

