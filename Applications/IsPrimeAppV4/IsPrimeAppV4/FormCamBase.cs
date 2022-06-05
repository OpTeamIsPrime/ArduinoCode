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
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace IsPrimeAppV4
{
    public partial class FormCamBase : Form
    {
        public bool Red=false;
        public bool Green=false;
        public bool Blue = false;
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

        private Color GetCol()
        {
            Color acc = Color.Orange;
            if (Green)
            {
                acc = Color.Green;
            }
            else if (Blue)
            {
                acc = Color.Blue;
            }
            return acc;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();//sem filtro
            Bitmap video1 = (Bitmap)eventArgs.Frame.Clone();// imagem com filtro

            BlobCounter bc = new BlobCounter
            {
                MinWidth = 5,
                MinHeight = 5,
                FilterBlobs = true,
                ObjectsOrder = ObjectsOrder.Size
            };

            EuclideanColorFiltering filter = new EuclideanColorFiltering
            {
                CenterColor = new RGB(GetCol()),
                Radius = 100
            };

            filter.ApplyInPlace(video1);//aplicando o filtro


            bc.ProcessImage(video1);// processando a imagem que ja foi filtrada para identificar objetos
            Rectangle[] rects = bc.GetObjectsRectangles();
            foreach (Rectangle recs in rects)
                if (rects.Length > 0)
                {
                    Rectangle objectRect = rects[0];
                    Graphics g = Graphics.FromImage(video);//identificar objetos a partir da imagem com filtro
                    Graphics h = Graphics.FromImage(video1);
                    using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                    {
                        g.DrawRectangle(pen, objectRect);
                        h.DrawRectangle(pen, objectRect);
                    }
                    g.Dispose();
                    h.Dispose();
                }
            pic.Image = video;
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

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Blue = true;
            Red = false;
            Green = false;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Green = true;
            Red = false;
            Blue = false;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            Red = true;
            Green = false;
            Blue = false;
        }
    }
}
