using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace restaurant_project
{
    public partial class Form3 : Form
    {
        Form4 f2 = new Form4();
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            { 
                disc = alltoal * 0;
                pricenet = alltoal - disc;
            }
            if (radioButton2.Checked)
            {
                disc = alltoal * 5 / 100;
                pricenet = alltoal - disc;
            }
            textBox2.Text = disc.ToString("#,##,00");
            textBox3.Text = pricenet.ToString("#,##,00");


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown4.Enabled = true;
                numericUpDown4.Value = 1;
                textBox9.Text = "ข้าวผัดทะเลรวม";
            }
            else
            {
                textBox9.Text = "";
                numericUpDown4.Enabled = false;
                numericUpDown4.Value = 0;
                button1_Click(sender, e);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown3.Enabled = true;
                numericUpDown3.Value = 1;
                textBox8.Text = "พืชซ้า";
            }
            else
            {
                textBox8.Text = "";
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 0;
                button1_Click(sender, e);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown2.Enabled = true;
                numericUpDown2.Value = 1;
                textBox7.Text = "สเต็กเนื้อ";
            }
            else
            {
                textBox7.Text = "";
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
                button1_Click(sender, e);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
                numericUpDown1.Value = 1;
                textBox6.Text = "สปาเก็ตตี้";
            }
            else
            {
                textBox6.Text = "";
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
                button1_Click(sender, e);
            }
        }
        double a1, a2, a3, a4, b1, b2, b3, b4, num1, num2, num3, num4, alltoal, disc, pricenet, vat, tolvat;

        private void button3_Click(object sender, EventArgs e)
        {
            {
                f2.Show();
                f2.textBox3.Text = textBox5.Text;
                f2.textBox6.Text = textBox6.Text + "\r\n" + textBox7.Text + "\r\n" + textBox8.Text 
                    + "\r\n" + textBox9.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Clear();
            textBox3.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button4_Click(sender, e);
            button1_Click(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button4_Click(sender, e);   
            button1_Click(sender, e);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;

            textBox11.Text = numericUpDown1.Value.ToString();
            textBox10.Text = numericUpDown2.Value.ToString();
            textBox13.Text = numericUpDown3.Value.ToString();
            textBox12.Text = numericUpDown4.Value.ToString();

            if (checkBox1.Checked)
            {
                b1 = double.Parse(textBox11.Text);
                    a1 = 60;
                num1 = b1 * a1;
            }
            else
            {
                b1 = double.Parse(textBox11.Text);
                a1 = 60;
                num1 = b1 * a1;
            }
            if (checkBox2.Checked)
            {
                b2 = double.Parse(textBox10.Text);
                a2 = 70;
                num2 = b2 * a2;
            }
            else
            {
                b2 = double.Parse(textBox10.Text);
                a2 = 70;
                num2 = b2 * a2;
            }
            if (checkBox3.Checked)
            {
                b3 = double.Parse(textBox13.Text);
                a3 = 80;
                num3 = b3 * a3;
            }
            else
            {
                b3 = double.Parse(textBox13.Text);
                a3 = 80;
                num3 = b3 * a3;
            }
            if (checkBox4.Checked)
            {
                b4 = double.Parse(textBox12.Text);
                a4 = 100;
                num4 = b4 * a4;
            }
            else
            {
                b4 = double.Parse(textBox12.Text);
                a4 = 100;
                num4 = b4 * a4;
            }
            alltoal = num1 + num2 + num3 + num4;
            button4_Click(sender, e);
            vat = pricenet * 7 / 100;
            tolvat = pricenet + vat;
            textBox4.Text = vat.ToString("#,##,00");
            textBox5.Text = tolvat.ToString("#,##,00");
            textBox1.Text = alltoal.ToString("#,##,00");

        }
    }
}
