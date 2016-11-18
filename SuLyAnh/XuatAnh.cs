using System.IO;
using System.Windows.Forms;

namespace SuLyAnh
{
    internal class XuatAnh
    {
        public static void LuuFileAnh(System.Drawing.Image img)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";// mac dinh file se la anh
            s.DefaultExt = ".Jpg";//mac dinh la jpg
            s.Filter = "Image (.jpg)|.jpg";//loc voi duoi  jpg
            if (s.ShowDialog() == DialogResult.OK)
            {
                //Luu anh
                string filename = s.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                img.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
            }
        }
    }
}