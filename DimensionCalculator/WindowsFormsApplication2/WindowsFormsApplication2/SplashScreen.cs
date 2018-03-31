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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        // set a time limit //

        Timer show;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            show = new Timer();
            show.Interval = 8000;
            show.Start();
            show.Tick += new EventHandler(show_Tick);

        }

        // close the splash screen and open the main application //

        void show_Tick(object sender, EventArgs e)
        {
            show.Stop();
            Calculator on = new Calculator();
            on.Show();
            this.Hide();
        }
    }
}
