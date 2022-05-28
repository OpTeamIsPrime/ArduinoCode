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
    public partial class IsPrimeFunction : Form
    {
        public IsPrimeFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPrimeNumber(Convert.ToInt32(textBox1.Text)) == false)
            {
                label3.Text = "This number is not a prime number";
            }
            else if (isPrimeNumber(Convert.ToInt32(textBox1.Text)))
            {
                label3.Text = "Yessss this number is a Prime Number";
            }
        }

        public static bool isPrimeNumber(int number)
        {
            int nb = 0;
            bool res = false;
            for (int i = 1; i < 10; i++)
            {
                if ((number % i) == 0)
                {
                    nb++;
                }
            }
            if (nb > 2)
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
