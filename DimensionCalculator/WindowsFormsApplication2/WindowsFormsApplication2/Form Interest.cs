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
    public partial class CInterest : Form
    {
        public CInterest()
        {
            InitializeComponent();
        }

        private void CInterest_Load(object sender, EventArgs e)
        {

        }

        // switch between forms //

        private void buttExchange_Click(object sender, EventArgs e)
        {

            CExchange now = new CExchange();
            now.Show();
            this.Hide();

        }

        private void butt_Cal_Click(object sender, EventArgs e)
        {

            Calculator one = new Calculator();
            one.Show();
            this.Hide();

        }

        // calculate the average //
        
        private void butt_average_Click(object sender, EventArgs e)
        {
            string text = txt_annul.Text;

            if(text == "0")
            {
                lbl_IntrAmmt.Text = "Please check your numbers";
            
            }
            else if (text != "0")
            {
                CInterest2 Interest = new CInterest2();

                try
                {
                    if (text != null)
                    {

                        //double rate = double.Parse(txtbox_rate.Text);
                        //double Pricipal = double.Parse(txtbx_principle.Text);

                        double p = Interest.CalculateInterest(Convert.ToDouble(txtbx_principle.Text), Convert.ToDouble(txtbox_rate.Text), Convert.ToDouble(txt_annul.Text) * 100);

                        lbl_IntrAmmt.Text = p.ToString("p");
                    }

                    if (text == "")
                    {

                        double h = Interest.CalculateInterest(Convert.ToDouble(txtbx_principle.Text), Convert.ToDouble(txtbox_rate.Text));
                        lbl_IntrAmmt.Text = h.ToString("p");

                    }

                }
                catch (OverflowException o) // create an overflow exception //
                {
                    MessageBox.Show(o.Message);

                }
                catch (FormatException a)
                {
                    MessageBox.Show(a.Message);

                
                }
            }
        }

        // clear all texts //

        private void butt_clear_Click(object sender, EventArgs e)
        {
            txt_annul.Text = "";
            txtbox_rate.Text = "";
            txtbx_principle.Text = "";
            lbl_IntrAmmt.Text = "";

        }

        // prevent strings and characters to being inputted //
 
        private void txtbx_principle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar=='.')
            {

            }

            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txt_annul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }

            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtbox_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '0')
            {

            }

            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }        
    }
}
