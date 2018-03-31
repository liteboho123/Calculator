using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionCalculator
{
    class CExchange2
    {
        

        public CExchange2()
        {

        }
        // summary //

        // create an Exchange rate constructor // 
   
        public double ConvertExchangeRate(double StartAmount, double TargetCurrency)
        {
            double EndAmmount = StartAmount * TargetCurrency;
            return EndAmmount;

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // CExchange
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 262);
        //    this.Name = "CExchange";
        //    this.ResumeLayout(false);

        //}
    } 
      

}
