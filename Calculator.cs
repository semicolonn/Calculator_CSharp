using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Form1 : Form
    {

        /*Created By BAHER <3_H.E edrisebaher@gmail.com || MU 2019_ BCS CSHARP*/
        string operatorSign = "";
        string keepValue = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                textBox1.Text = null;

            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+ "9";
            //textBox1.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                label2.Text = "";
            }
            else
            {
                operatorSign = "+";
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = textBox1.Text;
                label2.Text = "+";
                textBox1.Text = "";

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                label2.Text = "";

            }
            else
            {
                operatorSign = "-";
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = textBox1.Text;
                label2.Text = "-";
                textBox1.Text = "";

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                label2.Text = "";
            }
            else
            {
                operatorSign = "/";
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = textBox1.Text;
                label2.Text = "/";
                textBox1.Text = "";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                label2.Text = "";
            }
            else
            {

                operatorSign = "*";
                label1.Visible = true;
                label2.Visible = true;
                label1.Text = textBox1.Text;
                label2.Text = "*";
                textBox1.Text = "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
                //add
                if (operatorSign == "+")
                {

                    if (textBox1.Text =="" && label2.Text == operatorSign)
                    {

                        textBox1.Text = label1.Text;

                    }
                    else if(operatorSign=="+")
                    {
                        label3.Visible = true;
                        label3.Text = textBox1.Text;
                        double addition = Convert.ToDouble(label1.Text) + Convert.ToDouble(textBox1.Text);
                        textBox1.Text = addition.ToString();
                        //textBox1.Text = label1.Text + "+" + label3.Text + "="+ addition.ToString;
                    }
                }

            //minus
                if (operatorSign == "-")
                {

                    if (textBox1.Text == "" && label2.Text == operatorSign)
                    {

                        textBox1.Text = label1.Text;

                    }
                    else if (operatorSign == "-")
                    {
                        label3.Visible = true;
                        label3.Text = textBox1.Text;
                        double subtraction = Convert.ToDouble(label1.Text) - Convert.ToDouble(textBox1.Text);
                        textBox1.Text = subtraction.ToString();
                        //textBox1.Text = label1.Text + "+" + label3.Text + "="+ addition.ToString;
                    }
                }
            //multiply
                if (operatorSign == "*")
                {

                    if (textBox1.Text == "" && label2.Text == operatorSign)
                    {

                        textBox1.Text = label1.Text;

                    }
                    else if (operatorSign == "*")
                    {
                        label3.Visible = true;
                        label3.Text = textBox1.Text;
                        double multiplication = Convert.ToDouble(label1.Text) * Convert.ToDouble(textBox1.Text);
                        textBox1.Text = multiplication.ToString();
                        //textBox1.Text = label1.Text + "+" + label3.Text + "="+ addition.ToString;
                    }
                }

            //divid
                if (operatorSign == "/")
                {

                    if (textBox1.Text == "" && label2.Text == operatorSign)
                    {

                        textBox1.Text = label1.Text;

                    }
                    else if (operatorSign == "/")
                    {
                        label3.Visible = true;
                        label3.Text = textBox1.Text;
                        double division = Convert.ToDouble(label1.Text) / Convert.ToDouble(textBox1.Text);
                        textBox1.Text = division.ToString();
                        //textBox1.Text = label1.Text + "+" + label3.Text + "="+ addition.ToString;
                    }

                }

                 if (operatorSign == "")
                {
                    string keepNullVal = textBox1.Text;
                    
                    //label1.Text = textBox1.Text;
                }

                 if (textBox1.Text == "") {

                     textBox1.Text = textBox1.Text;
                 }
     
            
            
            
            //else if (label1.Text == textBox1.Text && operatorSign=="+" ||
                //    operatorSign=="-" || operatorSign=="*" || operatorSign=="/") {

                //    textBox1.Text = "";
                
                //}
            }
          
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = null;

            }
            else
            {
                textBox1.Text = textBox1.Text +".";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.ReadOnly = true;
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                textBox1.Text = "";
            }
            else
            {
                label2.Text = "";
                label3.Text = "";
                double sqrt_calc = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                label1.Visible = true;
                label1.Text = textBox1.Text;
                textBox1.Text = sqrt_calc.ToString();
            }

        }
    }
}
