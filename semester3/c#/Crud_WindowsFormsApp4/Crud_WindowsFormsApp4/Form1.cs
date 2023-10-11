using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public int std_id;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = u_name.Text;
            int age = Convert.ToInt32(u_age.Text);
            string city = u_city.SelectedItem.ToString();
            try
            {
                using(db_empEntities connection = new db_empEntities())
                {
                    tbl_std objstd = new tbl_std();
                    objstd.name = name;
                    objstd.age = age;
                    objstd.city = city;
                    connection.tbl_std.Add(objstd);
                    connection.SaveChanges();
                    MessageBox.Show("Data Inserted");
                    show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void show()
        {
            db_empEntities connection = new db_empEntities();
            List<tbl_std> std_list = connection.tbl_std.ToList();
            dataGridView1.DataSource = std_list;
        }

       

        private void btnView_Click(object sender, EventArgs e)
        {
            show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            this.std_id =Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString());
            u_name.Text = dataGridViewRow.Cells[1].Value.ToString();
            u_age.Text = dataGridViewRow.Cells[2].Value.ToString();
            u_city.SelectedItem = dataGridViewRow.Cells[3].Value.ToString();


            //MessageBox.Show(dataGridViewRow.Cells[1].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = u_name.Text;
            int age = Convert.ToInt32(u_age.Text);
            string city = u_city.SelectedItem.ToString();
            try
            {
                using (db_empEntities connection = new db_empEntities())
                {
                    tbl_std objstd = connection.tbl_std.Where(x => x.ID == this.std_id).FirstOrDefault() ;
                    objstd.name = name;
                    objstd.age = age;
                    objstd.city = city;
                    connection.Entry(objstd).State = System.Data.Entity.EntityState.Modified;
                    connection.SaveChanges();
                    MessageBox.Show("updated data");
                    show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db_empEntities connection = new db_empEntities();
            tbl_std objstd = connection.tbl_std.Where(x => x.ID == this.std_id).FirstOrDefault();
            connection.tbl_std.Remove(objstd);
            connection.SaveChanges();
            MessageBox.Show("Record Deleted Successfully");
            show();
            clearFields();
        }
        private void clearFields()
        {
            u_name.Text = "";
            u_age.Text = "";
            u_city.Text = "";
        }
    }
}
                            