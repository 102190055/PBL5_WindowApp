using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace PBL5
{
    public partial class Form2 : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam1;
        private VideoCaptureDevice cam2;
        Form1 mainform = new Form1();
        public Form2(Form callingform)
        {
            mainform = callingform as Form1;
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBoxCameraIn.Items.Add(info.Name);
                comboBoxCameraOut.Items.Add(info.Name);
            }
            comboBoxCameraIn.SelectedIndex = 0;
            comboBoxCameraOut.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cam1 != null && cam1.IsRunning)
            {
                cam1.Stop();
                
            }
            cam1 = new VideoCaptureDevice(cameras[comboBoxCameraIn.SelectedIndex].MonikerString);
            cam1.NewFrame += Cam1_NewFrame;
            cam1.Start();
        }
        private void Cam1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            this.mainform.pictureBox1.Image = bitmap;
        }

        private void buttonConnectCamera2_Click(object sender, EventArgs e)
        {
            if (cam2 != null && cam2.IsRunning)
            {
                cam2.Stop();
            } 
            cam2 = new VideoCaptureDevice(cameras[comboBoxCameraOut.SelectedIndex].MonikerString);      
            cam2.NewFrame += Cam2_NewFrame;
            cam2.Start();
        }
        private void Cam2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            this.mainform.pictureBox2.Image = bitmap;
        }
    }
}
