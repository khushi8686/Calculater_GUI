using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculater
{
    public partial class Form1 : Form
    {
       double number1, number2,results;
        string opration;
        public Form1()
        {
            InitializeComponent();
            Number1.ForeColor = SystemColors.GrayText;
            Number1.Text = "Enter the Number 1";
            this.Number1.Leave += new System.EventHandler(this.txt_Number1_Leave);
            this.Number1.Enter += new System.EventHandler(this.txt_Number1_Enter);
            Number2.ForeColor =SystemColors .GrayText;
            Number2.Text = "Enter the Number 2";
            this.Number2.Leave += new System.EventHandler(this.txt_Number2_Leave);
            this.Number2.Enter += new System.EventHandler(this.txt_Number2_Enter);
        }
        private void txt_Number1_Leave(object sender, EventArgs e)
        {
            if (Number1.Text.Length == 0)
            {
                Number1.Text = "Enter the Number 1";
                Number1.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_Number1_Enter(object sender, EventArgs e)
        {
            if (Number1.Text == "Enter the Number 1")
            {
                Number1.Text = "";
                Number1.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_Number2_Leave(object sender, EventArgs e)
        {
            if (Number2.Text.Length == 0)
            {
                Number2.Text = "Enter the Number 2";
                Number2.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_Number2_Enter(object sender, EventArgs e)
        {
            if (Number2.Text == "Enter the Number 2")
            {
                Number2.Text = "";
                Number2.ForeColor = SystemColors.WindowText;

            }
        }
            private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = Convert.ToDouble(Number1.Text);
                double number2 = Convert.ToDouble(Number2.Text);
                results = number1 + number2;
                opration="+";
                operater.Text = opration;
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Inputs");
            }

            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = Convert.ToDouble(Number1.Text);
                double number2 = Convert.ToDouble(Number2.Text);
                results = number1 * number2;
                opration = "X";
                operater.Text = opration;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Inputs");
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = Convert.ToDouble(Number1.Text);
                double number2 = Convert.ToDouble(Number2.Text);
                results = number1 / number2;
                opration = "÷";
                operater.Text = opration;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Inputs");
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if(opration==null)
            {
                MessageBox.Show("Please Choose Opration");
            }
            else
            {
                result.Text = ("Result: "+results).ToString();
            }
            
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = Convert.ToDouble(Number1.Text);
                double number2 = Convert.ToDouble(Number2.Text);
                results = number1 - number2;
                opration = "-";
                operater.Text = opration;

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Inputs");
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
