namespace IsPrimeAppV4
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
            panelAI.Visible = false;
            panelManual.Visible = false;
            btnManual.Visible = false;  
            btnAI.Visible = false;  
            lbAccess.Visible = false;
            lbUser1.Visible = false;
            txtUser.Visible = false;
            btnUser.Visible = false;

        }

        private void hideSubMenu()
        {
    
            if (panelAI.Visible)
            {
                panelAI.Visible = false;//Paneltest2 hiding (2eme panel)
            }
            if (panelManual.Visible)
            {
                panelManual.Visible = false;//Paneltest3 hiding (3eme panel)
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


        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            //openChilForm(new Form2());
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelManual);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAI);
        }
        private Form activeForm = null;
        /*private void openChilForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel4.Controls.Add(childForm);
                panel4.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }*/

       /* private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void brnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "caca")
            {
                btnAI.Visible = true;
                btnManual.Visible = true;
                btnPassword.Visible = false;
                lbPassword.Visible = false;
                txtBoxPassword.Visible = false;
                lbAccess.Visible = true;
                lbUser1.Visible = true;
                txtUser.Visible = true;
                btnUser.Visible = true;
            }
            else
            {
                
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            lbUser.Text = txtUser.Text;
        }
    }
}