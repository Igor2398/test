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

        private void Form2_Load(object sender, EventArgs e)
        {
            lblD.Text += ArcFurnanceDesign.d + " [m]";
            lblD1.Text += ArcFurnanceDesign.d1 + " [m]";
            lblD10.Text += ArcFurnanceDesign.d10 + " [m]";
            lblD2.Text += ArcFurnanceDesign.d2 + " [m]";
            lblD3.Text += ArcFurnanceDesign.d3 + " [m]";
            lblDn.Text += ArcFurnanceDesign.dn + " [m]";
            lblE.Text += ArcFurnanceDesign.e;
            lblG.Text += ArcFurnanceDesign.g + " Mg przy założeniach: ";
            lblGs1.Text += ArcFurnanceDesign.gs1 + " [m]";
            lblH.Text += ArcFurnanceDesign.h + " [m]";
            lblH1.Text += ArcFurnanceDesign.h1 + " [m]";
            lblH10.Text += ArcFurnanceDesign.h10 + " [m]";
            lblH2.Text += ArcFurnanceDesign.h2 + " [m]";
            lblH3.Text += ArcFurnanceDesign.h3 + " [m]";
            lblH4.Text += ArcFurnanceDesign.h4 + " [m]";
            lblK.Text += ArcFurnanceDesign.k + " stopni";
            lblKso.Text += ArcFurnanceDesign.kso + " ma następujące wymiary geometryczne: ";
            lblM.Text += ArcFurnanceDesign.m + " [m]";
            lblN.Text += ArcFurnanceDesign.n + " [m]";
            lblP.Text += ArcFurnanceDesign.p + " [m]"; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
