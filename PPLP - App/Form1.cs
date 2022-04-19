namespace PPLPApp
{
    public partial class ArcFurnanceDesign : Form
    {
        public ArcFurnanceDesign()
        {
            InitializeComponent();
        }

        public static double g, v2, ks;

        private void execButton_Click(object sender, EventArgs eventArgs)
        {
            double b1, e, k, aa;
            bool isValid = true; 

            if (!double.TryParse(steelMass.Text, out g))
            {
                MessageBox.Show("Wprowadzona wartosc cieklej stali jest bledna!");
                isValid = false;
            }
            if (!double.TryParse(slagToSteelParticipation.Text, out b1))
            {
                MessageBox.Show("Wprowadzona wartosc udzialu zuzlu jest bledna!");
                isValid = false;
            }
            if (!double.TryParse(additionalVol.Text, out e))
            {
                MessageBox.Show("Wprowadzona wartosc udzialu dodatkowej objetosci jest bledna!");
                isValid = false;
            }
            if (!double.TryParse(tiltAngle.Text, out k))
            {
                MessageBox.Show("Wprowadzona wartosc katu nachylenia jest bledna!");
                isValid = false;
            }
            if (!double.TryParse(diamToDepthRatio.Text, out ks))
            {
                MessageBox.Show("Wprowadzona wartosc stosunku do glebokosci jest bledna!");
                isValid = false;
            }

            if (isValid)
            {
                double b = b1 / 100;
                double a = 0.14;
                double c = 0.325;

                double v1 = a * g;
                v2 = v1 + b * c * g + e * v1;

                if (g <= 20)
                    aa = 0.31f;
                else if (g > 20 && g <= 50)
                    aa = 0.32f;
                else if (g > 50 && g <= 100)
                    aa = 0.33f;
                else if (g > 100)
                    aa = 0.345f;
                else
                    aa = 0;

                double ha = aa * Math.Pow(g, 0.25);
                double hb = Math.Pow((3000 * v2 / (3.14 * (675 * Math.Pow(ks, 2) - 1200 * ks * (1 / Math.Tan(k * 3.14 / 180)) + 704 * Math.Pow((1 / Math.Tan(k * 3.14 / 180)), 2 + 4)))), (double)1 / 3);
                empMetalBath.Text += ha;
                theorMetalBath.Text += hb;
                empMetalBath.Visible = true;
                theorMetalBath.Visible = true;
            }
        }
    }
}