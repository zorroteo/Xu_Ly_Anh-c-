using WebCam_Capture;

namespace SuLyAnh
{
    internal class webcam
    {
        private WebCamCapture mywebcam;
        private System.Windows.Forms.PictureBox _FrameImage;
        private int FrameNumber = 30;

        public void InitializeWebCam(ref System.Windows.Forms.PictureBox ImageControl)
        {
            mywebcam = new WebCamCapture();
            mywebcam.FrameNumber = (ulong)(0ul);
            mywebcam.TimeToCapture_milliseconds = FrameNumber;
            mywebcam.ImageCaptured += new WebCamCapture.WebCamEventHandler(mywebcam_ImageCaptured);
            _FrameImage = ImageControl;
        }

        private void mywebcam_ImageCaptured(object soure, WebcamEventArgs e)
        {
            _FrameImage.Image = e.WebCamImage;
        }

        public void Bat(int w, int h)
        {
            mywebcam.TimeToCapture_milliseconds = FrameNumber;
            mywebcam.Start(0);
            mywebcam.CaptureWidth = w;
            mywebcam.CaptureHeight = h;
        }

        public void Tat()
        {
            mywebcam.Stop();
        }

        public void TiepTuc(int w, int h)
        {
            //thay đổi khung thời gian chụp
            mywebcam.TimeToCapture_milliseconds = FrameNumber;

            //tiếp tục mở webcam cảu máy tính
            mywebcam.Start(this.mywebcam.FrameNumber);
            mywebcam.CaptureWidth = w;
            mywebcam.CaptureHeight = h;
        }

        public void ResolutionSetting()
        {
            mywebcam.Config();
        }

        public void AdvanceSetting()
        {
            mywebcam.Config2();
        }
    }
}