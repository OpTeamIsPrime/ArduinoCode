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
            if (txtBoxPassword.Text == "caca")
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
            Form2 form = new Form2();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }


        /*private void buttonlunchA_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            //openChilForm(new Form2());
        }

        private void buttonLunchM_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            //openChilForm(new Form2());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}