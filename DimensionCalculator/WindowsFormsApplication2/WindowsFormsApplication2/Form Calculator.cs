using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionCalculator
{
    
    public partial class Calculator : Form
    {
        bool plus = false;
        bool minus = false;
        bool multiply = false;
        bool divide = false;
        bool equals = false;

        public Calculator()
        {
            InitializeComponent();
        }
        // switch between forms //
        private void buttExchange_Click(object sender, EventArgs e)
        {
            
            CExchange now = new CExchange();
            now.Show();
            this.Hide();
            
        }

        private void butt_intr_Click(object sender, EventArgs e)
        {

            CInterest go = new CInterest();
            go.Show();
            this.Hide();


        }
        // create an addition method //

        private void butt_add_Click(object sender, EventArgs e)
        {

           if(textBox1.Text=="")
           {
               return;
           }
           else
           {
               plus = true;
               textBox1.Tag = textBox1.Text;
               textBox1.Text = "";
           }

        }

        // enter numeric keypads //

        private void button2_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "1";
        }

        private void CheckifEqual()
        {
            if (equals)
            {
                textBox1.Text = "";
                equals = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "5";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            textBox1.Text = textBox1.Text + "0";
        }

        // insert a decimal //

        private void butt_decimal_Click(object sender, EventArgs e)
        {
            CheckifEqual();
            if (textBox1.Text.Contains("."))
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        // insert a positive or minus sign //

        private void butt_plusminus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }
        
        
        // create an equal method  //
        // detect any error mistakes //
        private void butt_equals_Click(object sender, EventArgs e)
        {
            try
            {
                equals = true;

                if (plus)
                {
                    decimal dot = Convert.ToDecimal(textBox1.Tag) + Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = dot.ToString();
                }

                if (multiply)
                {
                    decimal dot = Convert.ToDecimal(textBox1.Tag) * Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = dot.ToString();
                }

                if (minus)
                {
                    decimal dot = Convert.ToDecimal(textBox1.Tag) - Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = dot.ToString();
                }

                if (divide)
                {
                    decimal dot = Convert.ToDecimal(textBox1.Tag) / Convert.ToDecimal(textBox1.Text);
                    textBox1.Text = dot.ToString();
                }
            }
            catch (DivideByZeroException px)
            {
                MessageBox.Show(px.Message);

            }
            catch (OverflowException o)
            {
                MessageBox.Show(o.Message);
            
            }
          
        }
        


        // create a minus method //

        private void butt_subtrct_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                minus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }

        }

        // create a multplication method //

        private void butt_Multiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                multiply = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        // create a division method //

        private void butt_Divide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                divide = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
            }
        }

        // create a clear button //

        private void butt_clear_Click(object sender, EventArgs e)
        {
            plus = minus = divide = multiply = equals = false;
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        // close the applcation when closing the program //

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // unable strings and characters to be inputted //

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar == '.' && e.KeyChar == '+' && e.KeyChar == '-'
                && e.KeyChar == '/' && e.KeyChar == '*')
            {

            }

            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
   
}       
        
    

