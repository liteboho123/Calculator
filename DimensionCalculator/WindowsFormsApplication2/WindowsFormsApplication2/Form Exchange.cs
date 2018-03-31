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
    public partial class CExchange : Form
    {

        List<string> _countries2 = new List<string>();
                        
        // store currency details in a combobox //
        public CExchange()
        {
            InitializeComponent();
            _countries2.Add("Choose own currency");
            _countries2.Add("Lesotho");
            _countries2.Add("South Africa");
            _countries2.Add("America");
            _countries2.Add("United Kingdom");
            _countries2.Add("Europe");

        
            comboBox2.DataSource = _countries2;
        }
 

       // switch between forms //
        private void butt_intr_Click(object sender, EventArgs e)
        {

            CInterest go = new CInterest();
            go.Show();
            this.Hide();
        }

        private void butt_Cal_Click(object sender, EventArgs e)
        {

            Calculator one = new Calculator();
            one.Show();
            this.Hide();
        }
        

        private void butt_convert_Click(object sender, EventArgs e)
        {
            CExchange2 exchange = new CExchange2();

            if (comboBox2.Text == "Lesotho")
            {
                double les = exchange.ConvertExchangeRate(Convert.ToDouble(textBox1.Text), 3.91);
                lbl_Amount.Text = les.ToString();
                lbl_icon.Text = "M";
                lbl_icon2.Text = "Muluti";
            }
            else if (comboBox2.Text == "South Africa")
            {
                double SA = exchange.ConvertExchangeRate(Convert.ToDouble(textBox1.Text), 8.02);
                lbl_Amount.Text = SA.ToString();
                lbl_icon.Text = "R";
                lbl_icon2.Text = "Rands";
            }
            else if (comboBox2.Text == "America")
            {
                double US = exchange.ConvertExchangeRate(Convert.ToDouble(textBox1.Text), 5.78);
                lbl_Amount.Text = US.ToString();
                lbl_icon.Text = "$";
                lbl_icon2.Text = "Dollars";
            }
            else if (comboBox2.Text == "Europe")
            {
                double EU = exchange.ConvertExchangeRate(Convert.ToDouble(textBox1.Text), 8.99);
                lbl_Amount.Text = EU.ToString();
                lbl_icon.Text = "C";
                lbl_icon2.Text = "Euro";
            }
            else if (comboBox2.Text == "United Kingdom")
            {
                double UK = exchange.ConvertExchangeRate(Convert.ToDouble(textBox1.Text), 3.90);
                lbl_Amount.Text = UK.ToString();
                lbl_icon.Text = "p";
                lbl_icon2.Text = "Pounds";
            }
            else if (comboBox2.Text == "Choose own currency")
            {
                double own = exchange.ConvertExchangeRate(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                lbl_Amount.Text = own.ToString();
            }
        }


        // enable strings and characters to not be inputted //

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '0')
            {

            }

            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    
        private void butt_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            lbl_Amount.Text = "0";
            lbl_icon.Text = "";
            lbl_icon2.Text = "";

        }

    }
}
 