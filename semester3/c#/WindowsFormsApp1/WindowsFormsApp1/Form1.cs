using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string n = u_name.Text;
            int age =Convert.ToInt32(u_age.Value.ToString());
            string city = u_city.SelectedValue.ToString();
            try
            {
                using(db_empEntities db = new db_empEntities())
                {
                    Model1 m = new Model1();
                    m.name
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
