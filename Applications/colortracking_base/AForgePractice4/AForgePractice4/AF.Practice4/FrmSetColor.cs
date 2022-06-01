using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AF.Practice4
{
    public partial class FrmSetColor : Form
    {
        private readonly MainForm _mainForm = (MainForm)Application.OpenForms["MainForm"];

        public FrmSetColor()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            chkActivePassive.Checked = _mainForm.ActivateColorTracking;//active la reconnaissance
            redTrackBar.Value = _mainForm.Red;
            greenTrackBar.Value = _mainForm.Green;
            blueTrackBar.Value = _mainForm.Blue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkActivePassive_CheckedChanged(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _mainForm.ActivateColorTracking = chkActivePassive.Checked;
            });
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _mainForm.Red = redTrackBar.Value;
            });
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _mainForm.Green = greenTrackBar.Value;
            });
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _mainForm.Blue = blueTrackBar.Value;
            });
        }
    }
}
