using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unknown
{
    public partial class Form1 : Form
    {

        private string number1 = "";
        private char method = ' ';
        private string number2 = "";


        private bool check = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void setnumber(double number)
        {
            if (this.check)
            {
                this.number2 += number.ToString();
                this.nmr2.Text = this.number2;
            }
            else
            {
                this.number1 += number.ToString();
                this.nmr1.Text = this.number1;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.number1 = "";
            this.method = ' ';
            this.number2 = "";
            this.textBox1.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            this.method = '+';
            this.check = true;
            this.op.Text = this.method.ToString();
        }

        private void keer_Click(object sender, EventArgs e)
        {
            this.method = '*';
            this.check = true;
            this.op.Text = this.method.ToString();
        }

        private void deel_Click(object sender, EventArgs e)
        {
            this.method = '/';
            this.check = true;
            this.op.Text = this.method.ToString();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.method = '-';
            this.check = true;
            this.op.Text = this.method.ToString();
        }

        private void iss_Click(object sender, EventArgs e)
        {
            if (this.number1.Length >= 1 && this.number2.Length >= 1 && this.method.ToString().Length == 1)
            {
                //parse strings to ints
                double temp1 = double.Parse(this.number1);
                double temp2 = double.Parse(this.number2);
                //stars switch
                switch (this.method)
                {
                    case '+':
                        //show result
                        //set number 1 result
                        this.number1 = (temp1 + temp2).ToString();
                        this.label1.Text = (temp1 + temp2).ToString();
                        this.cases(temp1, temp2);
                        break;

                    case '*':
                        //show result
                        //set number 1 result
                        this.number1 = (temp1 * temp2).ToString();
                        this.label1.Text = (temp1 * temp2).ToString();
                        this.cases(temp1, temp2);
                        break;

                    case '-':
                        //set number 1 result
                        this.number1 = (temp1 - temp2).ToString();
                        this.label1.Text = (temp1 - temp2).ToString();
                        this.cases(temp1, temp2);
                        break;

                    case '/':
                        //set number 1 result
                        this.number1 = (temp1 / temp2).ToString();
                        this.label1.Text = (temp1 / temp2).ToString();
                        this.cases(temp1, temp2);
                        break;

                    default:
                        break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            setnumber(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            setnumber(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            setnumber(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            setnumber(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            setnumber(5);
        }

        private void sixs_Click(object sender, EventArgs e)
        {
            setnumber(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            setnumber(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            setnumber(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            setnumber(9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setnumber(0);
        }

        private void komma_Click(object sender, EventArgs e)
        {
            if (!this.number1.Contains(","))
            {

                if (this.check)
                {
                    this.number2 += ",";
                    this.nmr2.Text = this.number2;

                }
                else
                {

                    this.number1 += ",";
                    this.nmr1.Text = this.number2;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cases(double temp1, double temp2)
        {
            //refresh nmr 1
            this.nmr1.Text = this.number1;
            //set number 2 emty
            this.number2 = "";
            //refresh label
            this.nmr2.Text = this.number2;
            this.textBox1.Text = this.number1;
        }
    }
}
