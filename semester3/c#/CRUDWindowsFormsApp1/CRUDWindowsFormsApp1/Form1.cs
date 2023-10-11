using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace CRUDWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection objSqlConn = new SqlConnection(cs);
            objSqlConn.Open();
            string query = "Insert into tbl_emp_detail (name ,email,phoneno,age) VALUES (@name,@email ,@phoneno ,@age)";
            SqlCommand ObjSqlcm = new SqlCommand(query, objSqlConn);
            ObjSqlcm.Parameters.AddWithValue("@name", emp_name.Text);
            ObjSqlcm.Parameters.AddWithValue("@email", emp_email.Text);
            ObjSqlcm.Parameters.AddWithValue("@phoneno", emp_phone.Text);
            ObjSqlcm.Parameters.AddWithValue("@age", emp_age.Text);


            ObjSqlcm.ExecuteNonQuery();
            objSqlConn.Close();
            MessageBox.Show("Successfully Inserted ");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection objSqlConn = new SqlConnection(cs);
            string query = "select * from tbl_emp_detail";
            //obj sql data adapter k pass data aya us ne fill krdia data form main datatable main ;
            SqlDataAdapter ObjSqlDataAdapter = new SqlDataAdapter(query, objSqlConn);
            DataTable data = new DataTable();
            ObjSqlDataAdapter.Fill(data);
           datalist.DataSource= data;

        }
    }
}
