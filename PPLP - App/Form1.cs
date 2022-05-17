namespace PPLPApp
{
    public partial class ArcFurnanceDesign : Form
    {
        public ArcFurnanceDesign()
        {
            InitializeComponent();
        }

        public static double g, v2, ks, d2, h3, h, b1, e, k, aa, b, a, c, v1, ha, hb, ba, h10, h2, h1, d2a, d2b, d3, d10, ca, d1, mo, eo, d, pp, pr, p, h4, dn, m, t, n, gs1, kso;
        private int clickCounter = 0;

        private void execButton_Click(object sender, EventArgs eventArgs)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                firstClick();
            }
            else if(clickCounter == 2)
            {
                secClick();
            }
            else
            {
                thrdClick();
            }
        }

        private void firstClick()
        {
            bool isValid = true;

            if (!double.TryParse(txtSteelMass.Text, out g))
            {
                MessageBox.Show("Wprowadzona wartosc cieklej stali jest bledna!");
                isValid = false; 
                clickCounter--;
                return;
            }
            if (!double.TryParse(txtSlagToSteelParticipation.Text, out b1))
            {
                MessageBox.Show("Wprowadzona wartosc udzialu zuzlu jest bledna!");
                isValid = false;
                clickCounter--;
                return;
            }
            if (!double.TryParse(txtAdditionalVol.Text, out e))
            {
                MessageBox.Show("Wprowadzona wartosc udzialu dodatkowej objetosci jest bledna!");
                isValid = false;
                clickCounter--;
                return;
            }
            if (!double.TryParse(txtTiltAngle.Text, out k))
            {
                MessageBox.Show("Wprowadzona wartosc katu nachylenia jest bledna!");
                isValid = false;
                clickCounter--;
                return;
            }
            if (!double.TryParse(txtDiamToDepthRatio.Text, out ks))
            {
                MessageBox.Show("Wprowadzona wartosc stosunku do glebokosci jest bledna!");
                isValid = false;
                clickCounter--;
                return;
            }

            if (isValid)
            {
                b = b1 / 100;
                a = 0.14;
                c = 0.325;

                v1 = a * g;
                v2 = v1 + b * c * g + e * v1;

                if (g <= 20)
                    aa = 0.31f;
                else if (g > 20 && g <= 50)
                    aa = 0.32f;
                else if (g > 50 && g <= 100)
                    aa = 0.33f;
                else
                    aa = 0.345f;

                ha = aa * Math.Pow(g, (double) 1/4);
                hb = Math.Pow((3000 * v2 / (3.14 * (675 * Math.Pow(ks, 2) - 1200 * ks * (1 / Math.Tan(k * 3.14 / 180)) + 704 * Math.Pow((1 / Math.Tan(k * 3.14 / 180)), 2 + 4)))), (double)1 / 3);
                empMetalBath.Text += ha;
                theorMetalBath.Text += hb;
                empMetalBath.Visible = true;
                theorMetalBath.Visible = true;

                txtDepth.Enabled = true;
                txtAdditionalVol.Enabled = false;
                txtDiamToDepthRatio.Enabled = false;
                txtSlagToSteelParticipation.Enabled = false;
                txtTiltAngle.Enabled = false;
                txtSteelMass.Enabled = false;
            }
        }

        private void secClick()
        {
            bool isValid = true;

            if (!double.TryParse(txtDepth.Text, out h))
            {
                MessageBox.Show("Wprowadzona wartosc cieklej stali jest bledna!");
                isValid = false;
                clickCounter--;
                return;
            }

            if (isValid)
            {
                h10 = 0.2 * h;
                h2 = 0.8 * h;

                if (g < 20)
                {
                    ba = 0.145;
                }
                else
                {
                    ba = 0.125;
                }

                h3 = ba * h;
                h1 = 0.75 * Math.Pow(g, 0.25);
                d2a = ks * h;
                d2b = 0.89 * h + Math.Sqrt(v2 / (0.71 * h) - Math.Pow(h, (double)2 / 4));

                lblEmp.Text += d2a;
                lblTheor.Text += d2b;
                lblEmp.Visible = true;
                lblTheor.Visible = true;

                btnNext.Text = "Oblicz";

                txtDiameter.Enabled = true;
                txtDepth.Enabled = false;
            }
        }

        private void thrdClick()
        {
            bool isValid = true;

            if (!double.TryParse(txtDiameter.Text, out d2))
            {
                MessageBox.Show("Wprowadzona wartosc srednicy jest bledna!");
                isValid = false;
                clickCounter--;
                return;
            }

            kso = d2 / h;

            if(isValid)
            {
                d3 = d2 - 1.6 * h * (1 / Math.Tan(k * 3.14 / 180));
                d10 = d2 + 2 * h3 * (1 / Math.Tan(k * 3.14 / 180));

                if (g < 20)
                {
                    ca = 0.075;
                }
                if (g >= 20)
                {
                    ca = 0.065;
                }

                d1 = d10 + 2 * ca * (0.75 * Math.Pow(g, 0.25 - h3));

                if (g <= 2)
                {
                    mo = 0.23;
                }
                if (g > 2 && g <= 10)
                {
                    mo = 0.30;
                }
                if (g > 10 && g <= 40)
                {
                    mo = 0.35;
                }
                if (g > 40)
                {
                    mo = 0.4;
                }

                eo = 0.075 + mo;
                d = d10 + 2 * eo;

                if (g < 25)
                {
                    pp = 0.16 * Math.Pow(g, 0.042);
                }
                if (g >= 25)
                {
                    pp = 0.88 * Math.Pow(g, 0.225);
                }
                if (g < 10)
                {
                    pr = 0.133 * Math.Pow(g, 0.3);
                }
                if (g >= 10)
                {
                    pr = 0.102 * Math.Pow(g, 0.379);
                }

                p = pp + pr + 0.15;
                h4 = 0.11 * d1;

                if (g < 15)
                {
                    t = 0.33;
                }
                if (g >= 15 && g < 40)
                {
                    t = 0.28;
                }
                if (g > 40)
                {
                    t = 0.23;
                }

                m = t * d10;
                n = 0.65 * m;
                dn = 0.135 * m;
                gs1 = 0.149 * Math.Pow(g, 0.174);

                Form f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }
    }
}