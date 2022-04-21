using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button6.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button6.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button5.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button5.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button1.BackColor = Color.Red;
                red++;
                green--;
            }
                else
                {
                    if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        button1.BackColor = Color.LawnGreen;
                    red--;
                    green++;
                }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        int red, green;

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button2.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button2.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button4.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button4.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button3.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button3.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button12.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button12.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button11.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button11.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button10.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button10.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button9.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button9.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button8.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button8.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button7.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button7.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button18.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button18.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button17.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button17.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button16.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button16.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button15.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button15.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button14.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button14.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button13.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button13.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button24.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button24.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button23.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button23.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button22.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button22.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button21.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button21.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button20.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button20.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการที่จะจองโต๊ะนี้ใช้หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button19.BackColor = Color.Red;
                red++;
                green--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการเซ็คบิลใช่หรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    button19.BackColor = Color.LawnGreen;
                red--;
                green++;
            }
            label5.Text = red.ToString();
            label4.Text = green.ToString();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.LawnGreen;
            button2.BackColor = Color.LawnGreen;
            button3.BackColor = Color.LawnGreen;
            button4.BackColor = Color.LawnGreen;
            button5.BackColor = Color.LawnGreen;
            button6.BackColor = Color.LawnGreen;
            button7.BackColor = Color.LawnGreen;
            button8.BackColor = Color.LawnGreen;
            button9.BackColor = Color.LawnGreen;
            button10.BackColor = Color.LawnGreen;
            button11.BackColor = Color.LawnGreen;
            button12.BackColor = Color.LawnGreen;
            button13.BackColor = Color.LawnGreen;
            button14.BackColor = Color.LawnGreen;
            button15.BackColor = Color.LawnGreen;
            button16.BackColor = Color.LawnGreen;
            button17.BackColor = Color.LawnGreen;
            button18.BackColor = Color.LawnGreen;
            button19.BackColor = Color.LawnGreen;
            button20.BackColor = Color.LawnGreen;
            button21.BackColor = Color.LawnGreen;
            button22.BackColor = Color.LawnGreen;
            button23.BackColor = Color.LawnGreen;
            button24.BackColor = Color.LawnGreen;


            if (button1.BackColor == Color.LawnGreen)
                green++;
            if (button2.BackColor == Color.LawnGreen)
                green++;
            if (button3.BackColor == Color.LawnGreen)
                green++;
            if (button4.BackColor == Color.LawnGreen)
                green++;
            if (button5.BackColor == Color.LawnGreen)
                green++;
            if (button6.BackColor == Color.LawnGreen)
                green++;
            if (button7.BackColor == Color.LawnGreen)
                green++;
            if (button8.BackColor == Color.LawnGreen)
                green++;
            if (button9.BackColor == Color.LawnGreen)
                green++;
            if (button10.BackColor == Color.LawnGreen)
                green++;
            if (button11.BackColor == Color.LawnGreen)
                green++;
            if (button12.BackColor == Color.LawnGreen)
                green++;
            if (button13.BackColor == Color.LawnGreen)
                green++;
            if (button14.BackColor == Color.LawnGreen)
                green++;
            if (button15.BackColor == Color.LawnGreen)
                green++;
            if (button16.BackColor == Color.LawnGreen)
                green++;
            if (button17.BackColor == Color.LawnGreen)
                green++;
            if (button18.BackColor == Color.LawnGreen)
                green++;
            if (button19.BackColor == Color.LawnGreen)
                green++;
            if (button20.BackColor == Color.LawnGreen)
                green++;
            if (button21.BackColor == Color.LawnGreen)
                green++;
            if (button22.BackColor == Color.LawnGreen)
                green++;
            if (button23.BackColor == Color.LawnGreen)
                green++;
            if (button24.BackColor == Color.LawnGreen)
                green++;

            label4.Text = green.ToString();
        }
    }
}
