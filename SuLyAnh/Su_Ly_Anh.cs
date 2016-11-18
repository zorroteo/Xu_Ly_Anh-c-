using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;

namespace SuLyAnh
{
    public partial class Su_Ly_Anh : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Su_Ly_Anh()
        {
            InitializeComponent();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
             
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = file.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(file.FileName);

                // Gán ảnh
                pictureBox1.Image = img;
            }
        }
        private void chup_anh_Click(object sender, EventArgs e)
        {
            var myForm = new chupanh();
            myForm.Show();
        }

        private void btn_damucxam_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = suly.grayscale(pictureBox1.Image);

        }
        OpenFileDialog file = new OpenFileDialog();

        private void btn_rotaflip_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = suly.rota_flip(pictureBox1.Image);
        }
        
        private void buttonX2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = suly.do_sang(pictureBox1.Image, Convert.ToInt32(n.Text));
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            var myForm = new Histogram();
            myForm.Show();
        }

        
        private void btntest_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = suly.Gaussian(pictureBox1.Image);

        }

        private void btnkhunhieu_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = suly.khu_nhieu(pictureBox1.Image);
        }
    }
}