using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2207B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = u_name.Text;

            MessageBox.Show(x);
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if(u_pass.UseSystemPasswordChar == true)
            {

            u_pass.UseSystemPasswordChar = false;
            }
            else
            {
                u_pass.UseSystemPasswordChar = true;

            }
        }
    }
}
