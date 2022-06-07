using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace IsPrimeAppV4
{
    public partial class SettingForm : Form
    {
        public Keys Forward1 = Keys.Z;
        public Keys Back1 = Keys.S;
        public Keys Right1 = Keys.D;
        public Keys Left1 = Keys.Q;
        public Keys Grab1 = Keys.Space;
        public Keys Stop1 = Keys.A;

        private readonly ManualForm _mainForm = (ManualForm)Application.OpenForms["ManualForm"];


        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            VForward.Text = txtForward.Text;
            VBack.Text = txtBack.Text;
            VRight.Text = txtRight.Text;
            VLeft.Text = txtLeft.Text;
            VGrab.Text = txtGrab.Text;
            VStop.Text = txtStop.Text;
            ManualForm frm = new ManualForm();
            frm.forward = Forward1;
            frm.back = Back1;
            frm.right = Right1;
            frm.left = Left1;
            frm.grab = Grab1;
            frm.stop = Stop1;
            frm.ShowDialog();
            label1.Text = "Keybinds change !";
        }

        private void txtForward_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtForward.Text.Length > 2)
                label1.Text = "You must enter just one key !";
            else
            {
               Forward1 = e.KeyCode;
            }

                
        }

        private void txtRight_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtRight.Text.Length > 2)
                label1.Text = "You must enter just one key";
            else
            {
                Right1 = e.KeyCode;
            }
        }

        private void txtLeft_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLeft.Text.Length > 2)
                label1.Text = "You must enter just one key";
            else
            {
                Left1 = e.KeyCode;
            }
        }

        private void txtBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBack.Text.Length > 2)
                label1.Text = "You must enter just one key";
            else
            {
                Back1 = e.KeyCode;
            }
        }

        private void txtGrab_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtGrab.Text.Length > 2)
                label1.Text = "You must enter just one key";
            else
            {
                Grab1 = e.KeyCode;
            }
        }

        private void txtStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtStop.Text.Length > 2)
                label1.Text = "You must enter just one key";
            else
            {
                Stop1 = e.KeyCode;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
