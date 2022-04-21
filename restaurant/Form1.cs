using restaurant_project;

namespace restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("โปรดกรอก Uesrname");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("โปรดกรอก Password");
                textBox2.Focus();
            }
            else if (textBox1.Text != "Eggy" || textBox2.Text != "1234")
            {
                MessageBox.Show("โปรดใช้ Username และ Password ให้ถูงต้อง");
                textBox2.Focus();
                textBox2.SelectAll();
            }
            else
            {
                this.Hide();
                MD f2 = new MD();
                f2.Show();


            }
        }
    }
}