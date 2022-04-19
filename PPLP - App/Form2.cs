using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPLPApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            double h, ba;
            bool isValid = true;

            if (!double.TryParse(txtDepth.Text, out h))
            {
                MessageBox.Show("Wprowadzona wartosc cieklej stali jest bledna!");
                isValid = false;
            }

            if(isValid)
            {
                double h10 = 0.2 * h;
                double h2 = 0.8 * h;

                if(ArcFurnanceDesign.g < 20)
                {
                    ba = 0.145;
                }
                else
                {
                    ba = 0.125;
                }

                double h3 = ba * h;
                double h1 = 0.75 * Math.Pow(ArcFurnanceDesign.g, 0.125);
                double d2a = ArcFurnanceDesign.ks * h;
                double d2b = 0.89 * h + Math.Sqrt(ArcFurnanceDesign.v2 / 0.71 * h) - Math.Pow(h, (double)2 / 4);

                lblEmp.Text += d2b;
                lblTheor.Text += d2a;
            }
        }
    }
}
