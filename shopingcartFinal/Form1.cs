using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopingcartFinal
{
    public partial class Form1 : Form
    {
        
        public string[] itemArray = new string[3];
        public int[] price = new int[3];
        int count;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             panel1.Visible = false;
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idx = 0;
            if (checkBox1.Checked == true) { itemArray[idx] = checkBox1.Text; price[idx] = 1000; idx++; }
            if (checkBox2.Checked == true) { itemArray[idx] = checkBox2.Text; price[idx] = 2000; idx++; }
            if (checkBox3.Checked == true) { itemArray[idx] = checkBox3.Text; price[idx] = 3000; idx++; }
            if (checkBox4.Checked == true) { itemArray[idx] = checkBox4.Text; price[idx] = 4000; idx++; }
            if (checkBox5.Checked == true) { itemArray[idx] = checkBox5.Text; price[idx] = 5000; idx++; }
            if (checkBox6.Checked == true) { itemArray[idx] = checkBox6.Text; price[idx] = 1500; idx++; }
            if (checkBox7.Checked == true) { itemArray[idx] = checkBox7.Text; price[idx] = 1040; idx++; }
            if (checkBox8.Checked == true) { itemArray[idx] = checkBox8.Text; price[idx] = 1300; idx++; }
            if (checkBox9.Checked == true) { itemArray[idx] = checkBox9.Text; price[idx] = 1200; idx++; }
            if (checkBox10.Checked == true) { itemArray[idx] = checkBox10.Text; price[idx] = 1000; idx++; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint_3(object sender, PaintEventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint_4(object sender, PaintEventArgs e)
        {
            label6.Text = itemArray[0];
            label7.Text = itemArray[1];
            label8.Text = itemArray[2];

            label9.Text = Convert.ToString(price[0]);
            label10.Text = Convert.ToString(price[1]);
            label11.Text = Convert.ToString(price[2]);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double total;
            double result;
            result = Convert.ToDouble(textBox4.Text) + Convert.ToDouble(price[0]);
            total = result;
            textBox7.Text = Convert.ToString(result);

            double result1;
            result1 = Convert.ToDouble(textBox5.Text) + Convert.ToDouble(price[1]);
            total = total + result1;
            textBox8.Text = Convert.ToString(result1);

            double result2;
            result2 = Convert.ToDouble(textBox6.Text) + Convert.ToDouble(price[2]);
            total = total + result2;
            textBox9.Text = Convert.ToString(result2);

            textBox1.Text = Convert.ToString(total);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            count = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox1.Text = " ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if(checkBox1.Checked == true)
            {
                count++;
                if(count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox1.Checked = false;
                }
            }

 
          
            // checkBoxes Validation
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox2.Checked = false;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox3.Checked = false;
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox4.Checked = false;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox5.Checked = false;
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox6.Checked = false;
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox7.Checked = false;
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox8.Checked = false;
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox9.Checked = false;
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                count++;
                if (count > 3)
                {
                    MessageBox.Show("SORRY : You can't chosse items more then 3 :(");
                    checkBox10.Checked = false;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
