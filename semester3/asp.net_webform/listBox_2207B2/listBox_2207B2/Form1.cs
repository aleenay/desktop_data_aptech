using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox_2207B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_items_Click(object sender, EventArgs e)
        {
            if(itemname.Text == "")
            {
                MessageBox.Show("Enter Item name");
            }
            else
            {

            listBox1.Items.Add(itemname.Text);
            itemname.Clear();
            itemname.Focus();

            }

          //  itemname.Text;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int Itemscount = listBox1.Items.Count;
            MessageBox.Show("List Count " + Itemscount);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
