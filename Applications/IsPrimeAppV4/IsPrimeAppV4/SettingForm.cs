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
            
        }
    }
}
