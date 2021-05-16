using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Arthimatic_Operation b1 = new Arthimatic_Operation();
            label2.Text = b1.sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arthimatic_Operation b2 = new Arthimatic_Operation();
            label2.Text = b2.sub(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arthimatic_Operation b3 = new Arthimatic_Operation();
            label2.Text = b3.mul(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Arthimatic_Operation b4 = new Arthimatic_Operation();
            label2.Text = b4.div(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Arthimatic_Operation b5 = new Arthimatic_Operation();
            label2.Text = b5.mod(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Logical_Operation.logic l2 = new Logical_Operation.logic();
            label2.Text = l2.NOT(Convert.ToBoolean(textBox1.Text), Convert.ToBoolean(textBox2.Text)) + "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Temperature_Converter b13 = new Temperature_Converter();
            label6.Text = b13.cel(Convert.ToDouble(textBox3.Text)) + "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Logical_Operation.logic l1 = new Logical_Operation.logic();
            label2.Text = l1.AND(Convert.ToBoolean(textBox1.Text), Convert.ToBoolean(textBox2.Text)) + "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Logical_Operation.logic l3 = new Logical_Operation.logic();
            label2.Text = l3.OR(Convert.ToBoolean(textBox1.Text), Convert.ToBoolean(textBox2.Text)) + "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Logical_Operation.logic l4 = new Logical_Operation.logic();
            label2.Text = l4.XOR(Convert.ToBoolean(textBox1.Text), Convert.ToBoolean(textBox2.Text)) + "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Logical_Operation.logic l5 = new Logical_Operation.logic();
            label2.Text = l5.XNOR(Convert.ToBoolean(textBox1.Text), Convert.ToBoolean(textBox2.Text)) + "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Logical_Operation.logic l6 = new Logical_Operation.logic();
            label2.Text = l6.NAND(Convert.ToBoolean(textBox1.Text), Convert.ToBoolean(textBox2.Text)) + "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(">*>*>*>*>Thank you for using this calculator<*<*<*<*<");
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Temperature_Converter b14 = new Temperature_Converter();
            label6.Text = b14.feh(Convert.ToDouble(textBox3.Text)) + "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Logical_Operation.logic l7 = new Logical_Operation.logic();
            label2.Text = l7.NOR(Convert.ToBoolean(textBox1.Text), Convert.ToBoolean(textBox2.Text)) + "";
        }
    }
    }

