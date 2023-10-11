namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtItem.Text == "")
            {
                MessageBox.Show("Enter items name");
                txtItem.Focus();
            }
            else
            {
            ItemListBox.Items.Add(txtItem.Text);
                txtItem.Clear();
                txtItem.Focus();
            }

          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = ItemListBox.Items.Count;
            MessageBox.Show("List Items are " + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemListBox.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemListBox.Items.Remove(ItemListBox.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ItemListBox.Items.Clear();
        }
    
    }
}