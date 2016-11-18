using System;
using System.Windows.Forms;

namespace SuLyAnh
{
    public partial class Form1 : Form
    {
        private webcam mywebcam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mywebcam = new webcam();
            mywebcam.InitializeWebCam(ref pictureBox1);
        }

        private void btnBat_Click(object sender, EventArgs e)
        {
            mywebcam.Bat(640, 480);
        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            mywebcam.Tat();
            pictureBox1.Image = null;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            mywebcam.TiepTuc(640, 480);
        }

        private void btnChup_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }
    }
}