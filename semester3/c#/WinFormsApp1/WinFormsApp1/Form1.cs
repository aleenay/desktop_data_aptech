namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static string username ;
        public static string password ;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtbox_1.Text);
            int num2 = int.Parse(txtbox_2.Text);
            int result = num1 + num2;
            MessageBox.Show(result.ToString());
            //lbl_u_name.Text = u_name.Text;
            //MessageBox.Show(u_name.Text);
            //MessageBox.Show("Working");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtbox_1.Text);
            int num2 = int.Parse(txtbox_2.Text);
            int result = num1 - num2;
            MessageBox.Show(result.ToString());
             
        }

        private void btn_Click(object sender, EventArgs e)
        {
            username = user_name.Text;
            password = user_pass.Text;
            Form2 form = new Form2();
            form.Show();
        }
    }
}