namespace SuLyAnh
{
    partial class chupanh
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
            this.btn_chup = new DevComponents.DotNetBar.ButtonX();
            this.btn_lai = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_setting = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbdophangiai = new System.Windows.Forms.Label();
            this.cbndophangiai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_chup
            // 
            this.btn_chup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_chup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_chup.Location = new System.Drawing.Point(632, 67);
            this.btn_chup.Name = "btn_chup";
            this.btn_chup.Size = new System.Drawing.Size(75, 23);
            this.btn_chup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_chup.TabIndex = 1;
            this.btn_chup.Text = "Chụp ảnh";
            this.btn_chup.Click += new System.EventHandler(this.btn_chup_Click);
            // 
            // btn_lai
            // 
            this.btn_lai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_lai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_lai.Location = new System.Drawing.Point(632, 137);
            this.btn_lai.Name = "btn_lai";
            this.btn_lai.Size = new System.Drawing.Size(75, 23);
            this.btn_lai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_lai.TabIndex = 3;
            this.btn_lai.Text = "lại";
            this.btn_lai.Click += new System.EventHandler(this.btn_lai_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(632, 222);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_setting.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_setting.Location = new System.Drawing.Point(632, 346);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(75, 23);
            this.btn_setting.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_setting.TabIndex = 5;
            this.btn_setting.Text = "Cài đặt";
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SuLyAnh.Properties.Resources.Creative_Film_Vinyl_Wall_Decal_font_b_Camera_b_font_Film_Mural_Art_Wall_font_b;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbdophangiai);
            this.groupPanel1.Controls.Add(this.cbndophangiai);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(353, 222);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(243, 147);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 6;
            this.groupPanel1.Text = "groupPanel1";
            // 
            // lbdophangiai
            // 
            this.lbdophangiai.AutoSize = true;
            this.lbdophangiai.Location = new System.Drawing.Point(3, 22);
            this.lbdophangiai.Name = "lbdophangiai";
            this.lbdophangiai.Size = new System.Drawing.Size(74, 13);
            this.lbdophangiai.TabIndex = 1;
            this.lbdophangiai.Text = "Độ phân giải";
            // 
            // cbndophangiai
            // 
            this.cbndophangiai.DisplayMember = "Text";
            this.cbndophangiai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbndophangiai.ForeColor = System.Drawing.Color.Black;
            this.cbndophangiai.FormattingEnabled = true;
            this.cbndophangiai.ItemHeight = 16;
            this.cbndophangiai.Location = new System.Drawing.Point(97, 22);
            this.cbndophangiai.Name = "cbndophangiai";
            this.cbndophangiai.Size = new System.Drawing.Size(121, 22);
            this.cbndophangiai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbndophangiai.TabIndex = 0;
            this.cbndophangiai.SelectedIndexChanged += new System.EventHandler(this.cbndophangiai_SelectedIndexChanged);
            // 
            // chupanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 462);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_lai);
            this.Controls.Add(this.btn_chup);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "chupanh";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.chupanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btn_chup;
        private DevComponents.DotNetBar.ButtonX btn_lai;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_setting;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label lbdophangiai;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbndophangiai;
    }
}