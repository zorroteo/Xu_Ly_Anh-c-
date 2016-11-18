using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuLyAnh
{
    public partial class Histogram : DevComponents.DotNetBar.Metro.MetroForm
    {
        private Image image;

        public Histogram()
        {
            InitializeComponent();
        }

        public Histogram(Image image)
        {
            this.image = image;
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            // pictureBox1.Image = image;
            // pictureBox2.Image = suly.histogram(pictureBox1.Image);
        }

        private OpenFileDialog file = new OpenFileDialog();

        private void pictureBox1_Click(object sender, EventArgs e)
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

            pictureBox2.Image = suly.histogram(pictureBox1.Image);
        }
    }
}