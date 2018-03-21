using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double a, b, c;
        //double [] numbers;
        double []numbers= new double[5];
        double[] anumbers = new double[5];
        string first, second;
        char m;
        int i=0,j=0,k=0,l=0;
        bool number1 = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (s == "")
            {
                s += "1";
            }*/
            if (number1 == true)
            {

                first += "1";
                textBox1.Text = this.first.ToString();
            }
            else if (number1 == false)
            {
                second += "1";
                textBox3.Text = this.second.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "2"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "2"; textBox3.Text = this.second.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "3"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "3"; textBox3.Text = this.second.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "4"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "4"; textBox3.Text = this.second.ToString();


            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "5"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "5"; textBox3.Text = this.second.ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "6"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "6"; textBox3.Text = this.second.ToString();

            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "7"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "7"; textBox3.Text = this.second.ToString();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "8"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "8"; textBox3.Text = this.second.ToString();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "9"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "9"; textBox3.Text = this.second.ToString();

            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "0"; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "0"; textBox3.Text = this.second.ToString();

            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            number1 = false;
            m = '+';
            textBox2.Text = this.m.ToString();
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            number1 = false;
            m = '-';
            textBox2.Text = this.m.ToString();
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            number1 = false;
            m = '*';
            textBox2.Text = this.m.ToString();
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            number1 = false;
            m = '/';
            textBox2.Text = this.m.ToString();
        }

        private void buttonequ_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                a = Convert.ToDouble(first);
                b = Convert.ToDouble(second);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            switch (m)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
            }
            textBox4.Text = this.c.ToString();
            for (k = l; k < 4; i++)
            {
                anumbers[k] = c;
                if (k == 0)
                {
                    arcd1.Text = anumbers[k].ToString();
                    l++;
                    break;

                }
                if (k == 1)
                {
                    arcd2.Text = anumbers[k].ToString();

                    l++;
                    break;

                }
                if (k == 2)
                {
                    arcd3.Text = anumbers[k].ToString();
                    l++;
                    break;

                }
                if (k == 3)
                {
                    arcd4.Text = anumbers[k].ToString();
                    l = 0;
                    break;

                }
            }
            //numb = c.ToString;
            //textBox4.Text=(string)c;

        }

        

        private void buttondot_Click(object sender, EventArgs e)
        {
            if (number1 == true)
            {

                first += "."; textBox1.Text = this.first.ToString();

            }
            else if (number1 == false)
            {
                second += "."; textBox3.Text = this.second.ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //first.ToString.textBox1();

        }

        private void allclear_Click(object sender, EventArgs e)
        {
            number1 = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            a = 0;
            b = 0;
            c = 0;
            first = "";
            second = "";
            
        }

        

        private void rcd1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rcd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rcd3_TextChanged(object sender, EventArgs e)
        {

        }

        private void record_Click(object sender, EventArgs e)
        {
            for (i = j; i < 4; i++)
            {
                numbers[i] = c;
                if (i == 0)
                {
                    rcd1.Text = numbers[i].ToString();
                    j++;
                    break;

                }
                if (i == 1)
                {
                    rcd2.Text = numbers[i].ToString();

                    j++;
                    break;

                }
                if (i == 2)
                {
                    rcd3.Text = numbers[i].ToString();
                    j++;
                    break;

                }
                if (i == 3)
                {
                    rcd4.Text = numbers[i].ToString();
                    j = 0;
                    break;

                }
            }
        }

        private void arcd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void arcd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void arcd3_TextChanged(object sender, EventArgs e)
        {

        }

        private void arcd4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rcd4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /* m = Convert.ToChar(textBox2.Text.ToString());*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*if (number2 == false)
            {
                b = Convert.ToDouble(textBox3.Text.ToString());
                number2 = true;
            }*/
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
