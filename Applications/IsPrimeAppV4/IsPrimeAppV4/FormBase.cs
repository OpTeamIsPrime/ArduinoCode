
namespace IsPrimeAppV4
{
    public partial class FormBase : Form
    {
        
        
        public FormBase()
        {
            InitializeComponent();
            panelAI.Visible = false;  
            btnDash.Visible = true;  
            lbAccess.Visible = false;
            lbUser1.Visible = false;
            txtUser.Visible = false;
            btnUser.Visible = false;
            btnAI.Visible = false;
            btnManual.Visible = false;
            panelManual.Visible = false;
            CheckForIllegalCrossThreadCalls = false;
        }
        

        private void hideSubMenu()
        {
    
            if (panelAI.Visible)
            {
                panelAI.Visible = false;//Paneltest2 hiding (2eme panel)
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
      


        private void button9_Click_1(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "IsPrimeProject")
            { 
           
                btnPassword.Visible = false;
                lbPassword.Visible = false;
                txtBoxPassword.Visible = false;
                lbAccess.Visible = true;
                lbUser1.Visible = true;
                txtUser.Visible = true;
                btnUser.Visible = true;
                btnManual.Visible=true;
                btnAI.Visible=true;
            }
        }

      

        private void btnManual_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelManual);
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAI);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            labelUser.Text = txtUser.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCamBase form = new FormCamBase();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManualForm form = new ManualForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm();
            form.Show();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            IsPrimeFunction form = new IsPrimeFunction();
            form.Show();
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnPassword.Focus();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labelUser.Text = txtUser.Text;
            }
        }
    }
}