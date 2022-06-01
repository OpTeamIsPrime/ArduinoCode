using Module.AForge.Extensions;
using Module.AForge.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AF.Practice4
{
    public partial class MainForm : Form
    {
        public CaptureDevice CurrCaptureDevice { get; set; }
        public bool ActivateColorTracking = false;
        public bool ShowOrjinalOrProcessImage = true;
        public bool MultiOrSingleTracking = true;
        public int Red;
        public int Green;
        public int Blue;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrCaptureDevice != null && CurrCaptureDevice.IsRunning())
                CurrCaptureDevice.Dispose();
            CurrCaptureDevice = null;

            var frmSetCamera = new FrmSetCamera();
            if (frmSetCamera.ShowDialog() != DialogResult.OK) return;

            if (CurrCaptureDevice != null)
            {
                // ReSharper disable once DelegateSubtraction
                CurrCaptureDevice.NewFramEventHandler -= NewFramEventHandler;
                CurrCaptureDevice.NewFramEventHandler += NewFramEventHandler;
            }
            startToolStripMenuItem_Click(null, null);
        }
        public void NewFramEventHandler(object sender, Bitmap bitmap)
        {
            try
            {
                if (!ActivateColorTracking)
                {
                    var clone = (Bitmap)bitmap.Clone();//renvoit juste l'image de base
                    pbOrjinalimage.Image = clone;
                    return;
                }

                if (ShowOrjinalOrProcessImage)
                {
                    var processedOrjinalBitmap = bitmap.FindObjectsOnOrjinal(penColor: Color.Red, filterColor: Color.FromArgb(Red, Green, Blue), multiple: MultiOrSingleTracking);
                    pbOrjinalimage.Image = processedOrjinalBitmap;
                    return;
                }

                var filteredBitmap = bitmap.EuclideanFilter(Color.FromArgb(Red, Green, Blue));
                var processedFilteredBitmap = filteredBitmap.FindObjectsOnFiltered(Color.Red, multiple: MultiOrSingleTracking);
                pbOrjinalimage.Image = processedFilteredBitmap;

            }
            catch
            {
                //ignored
            }
        }

        #region Camera Menu
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CurrCaptureDevice == null)
            {
                MessageBox.Show("Set Up Device!", "Warning");
                return;
            }
            CurrCaptureDevice.StartCapture();
            #region Resize PictureBox and Form 
            pbOrjinalimage.Width = CurrCaptureDevice.Width;
            pbOrjinalimage.Height = CurrCaptureDevice.Height;
            Width = pbOrjinalimage.Width;
            Height = pbOrjinalimage.Height + 65;
            #endregion Resize PictureBox and Form 
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrCaptureDevice == null)
            {
                MessageBox.Show("Set Up Device!", "Warning");
                return;
            }
            CurrCaptureDevice.StopCapture();
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrCaptureDevice == null)
            {
                MessageBox.Show("Set Up Device!", "Warning");
                return;
            }
            CurrCaptureDevice.StopCapture();
            pbOrjinalimage.Image = null;
            pbOrjinalimage.BackColor = Color.Black;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Camera Menu        

        #region Image Process Menu
        private void colorTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSetColor = (FrmSetColor)Application.OpenForms["FrmSetColor"];
            frmSetColor?.Focus();

            if (frmSetColor != null) return;
            frmSetColor = new FrmSetColor();
            frmSetColor.Show();
        }
        private void showOrjinalOrProcessImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrjinalOrProcessImage = showOrjinalOrProcessImageToolStripMenuItem.Checked;//active la reconnaissance
        }
        private void multiOrSingleTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiOrSingleTracking = multiOrSingleTrackingToolStripMenuItem.Checked;
        }
        #endregion Image Process Menu

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (CurrCaptureDevice != null && CurrCaptureDevice.IsRunning())
            {
                try
                {
                    CurrCaptureDevice.StopCapture();
                    CurrCaptureDevice = null;
                }
                catch
                {
                    // ignored
                }
            }

            base.OnClosing(e);
        }
    }
}
