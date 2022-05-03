using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AForge;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;


namespace IsPrimeAppV4
{
    public partial class FormCamBase : Form
    {
        public bool ActivateColorTracking = false;
        public bool ShowOrjinalOrProcessImage = true;
        public bool MultiOrSingleTracking = true;
        public bool Red;
        public bool Green;
        public bool Blue;
        public FormCamBase()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;


        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pic.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboCamera.Items.Add(filterInfo.Name);
            }
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }
        /* public void NewFramEventHandler(object sender, Bitmap bitmap)
         {
             try
             {
                 if (!ActivateColorTracking)
                 {
                     var clone = (Bitmap)bitmap.Clone();
                     pic.Image = clone;
                     return;
                 }

                 if (ShowOrjinalOrProcessImage)
                 {
                     var processedOrjinalBitmap = bitmap.FindObjectsOnOrjinal(penColor: Color.Red, filterColor: Color.FromArgb(Red, Green, Blue), multiple: MultiOrSingleTracking);
                     pic.Image = processedOrjinalBitmap;
                     return;
                 }

                 var filteredBitmap = bitmap.EuclideanFilter(Color.FromArgb(Red, Green, Blue));
                 var processedFilteredBitmap = filteredBitmap.FindObjectsOnFiltered(Color.Red, multiple: MultiOrSingleTracking);
                 pic.Image = processedFilteredBitmap;

             }
             catch
             {
                 //ignored
             }
         }*/
        protected override void OnClosing(CancelEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                try
                {
                    videoCaptureDevice.Stop();
                    videoCaptureDevice = null;
                }
                catch
                {
                    // ignored
                }
            }

            base.OnClosing(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
