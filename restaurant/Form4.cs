using restaurant_project;
using System.Text;

namespace restaurant_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double ton, pricenet, allton;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = this.allton.ToString();

            string strData = null;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != null)
                {

                                strData += allton.ToString() + "บาท เงินทอนอาหารทั้งหมด";
                                    strData += "\r\n";
                                //todo: save from dataGridView1 to variable

                }

                    //save File
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);


                

            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pricenet = double.Parse(textBox3.Text);
            ton = double.Parse(textBox4.Text);
            allton = ton - pricenet;
            MessageBox.Show("เงินทอนหอาหาร" +  allton + "บาท");
        }
    }
}
