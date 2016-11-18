namespace SuLyAnh
{
    partial class test_webcam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBat = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnTat = new System.Windows.Forms.Button();
            this.btnChup = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(41, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBat
            // 
            this.btnBat.Location = new System.Drawing.Point(444, 38);
            this.btnBat.Name = "btnBat";
            this.btnBat.Size = new System.Drawing.Size(75, 23);
            this.btnBat.TabIndex = 1;
            this.btnBat.Text = "Bật";
            this.btnBat.UseVisualStyleBackColor = true;
            this.btnBat.Click += new System.EventHandler(this.btnBat_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(444, 184);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(75, 23);
            this.btnTiepTuc.TabIndex = 2;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnTat
            // 
            this.btnTat.Location = new System.Drawing.Point(444, 107);
            this.btnTat.Name = "btnTat";
            this.btnTat.Size = new System.Drawing.Size(75, 23);
            this.btnTat.TabIndex = 2;
            this.btnTat.Text = "Tắt";
            this.btnTat.UseVisualStyleBackColor = true;
            this.btnTat.Click += new System.EventHandler(this.btnTat_Click);
            // 
            // btnChup
            // 
            this.btnChup.Location = new System.Drawing.Point(444, 240);
            this.btnChup.Name = "btnChup";
            this.btnChup.Size = new System.Drawing.Size(75, 23);
            this.btnChup.TabIndex = 3;
            this.btnChup.Text = "Chụp ảnh";
            this.btnChup.UseVisualStyleBackColor = true;
            this.btnChup.Click += new System.EventHandler(this.btnChup_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(555, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 242);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 474);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnChup);
            this.Controls.Add(this.btnTat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnBat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBat;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnTat;
        private System.Windows.Forms.Button btnChup;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

