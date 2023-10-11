using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public static string username;
        public static string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (u_name.Text != "")
            {

                //if (u_name.Text == "admin" && u_password.Text == "admin")
                //{
                username = u_name.Text;
                password = u_password.Text;
                Form2 obj = new Form2();
                obj.Show();

                //MessageBox.Show("You are login");

                //}
                //else
                //{
                //    MessageBox.Show("Invalid username of password");
                //}
            }
            else
            {
                MessageBox.Show("Enter username");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (u_password.UseSystemPasswordChar == true)
            {
                btnHS.Text = "Hide";
                u_password.UseSystemPasswordChar = false;
            }
            else
            {
                u_password.UseSystemPasswordChar = true;
                btnHS.Text = "show";

            }
        }
    }
}