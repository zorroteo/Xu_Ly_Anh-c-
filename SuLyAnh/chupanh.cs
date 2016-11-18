using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace SuLyAnh
{
    public partial class chupanh : DevComponents.DotNetBar.Metro.MetroForm
    {
        webcam mywebcam;
        public chupanh()
        {
            InitializeComponent();
        }

        #region combpbox_item
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        #endregion

        private void chupanh_Load(object sender, EventArgs e)
        {
            mywebcam = new webcam();
            mywebcam.InitializeWebCam(ref pictureBox1);

            ComboboxItem item = new ComboboxItem();
            item.Text = "320x240";
            item.Value = 320;
            cbndophangiai.Items.Add(item);

            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "640x480";
            item1.Value = 640;
            cbndophangiai.Items.Add(item1);

            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "1280x720";
            item2.Value = 1280;
            cbndophangiai.Items.Add(item2);

            cbndophangiai.SelectedIndex = 2;

            mywebcam.Bat(620, 480);

            groupPanel1.Hide();
        }

        private void btn_lai_Click(object sender, EventArgs e)
        {
            mywebcam.TiepTuc(620,480);
        }

        private void btn_chup_Click(object sender, EventArgs e)
        {
            Image a = pictureBox1.Image;
            mywebcam.Tat();
            pictureBox1.Image = a;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            XuatAnh.LuuFileAnh(pictureBox1.Image);
        }

        private void cbndophangiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbndophangiai.SelectedIndex== 0)
            {
                mywebcam.TiepTuc(320, 240);
                groupPanel1.Hide();
            }
            if (cbndophangiai.SelectedIndex == 1)
            {
                mywebcam.TiepTuc(640, 480);
                groupPanel1.Hide();
            }
            if (cbndophangiai.SelectedIndex == 2)
            {
                mywebcam.TiepTuc(1280, 720);
                groupPanel1.Hide();
            }
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            groupPanel1.Show();
        }
    }
}