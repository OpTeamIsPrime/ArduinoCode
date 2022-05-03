using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsPrimeAppV4
{
    public partial class SettingForm : Form
    {
        private readonly FormCamBase _mainForm = (FormCamBase)Application.OpenForms["MainForm"];

        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            _mainForm.Blue = true;

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            _mainForm.Green = true;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            _mainForm.Red = true;
        }
    }
}
