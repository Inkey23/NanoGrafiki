using MathNet.Numerics.Integration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integral_Grafiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double T1 = 300, T2 = 1000, Th = 100, T = 0, MU1 = 0, MU2 = 5, MUh = 1, MU = 0, Eg1 = 0, Eg2 = 5, Egh = 1, Eg = 0, V1 = 0, V2 = 1000, Vh = 100, V = 0, G = 0, I = 0;
        double x = 0, y = 0, C1 = 0, C2 = 0, Ch = 0, C = 0, e1 = 1.6 * Math.Pow(10, -19), Koef = 0.0000775, k = 0.000086173, H = 6.626 * Math.Pow(10, -34);
        string TextT1, TextT2, TextTh, TextMU1, TextMU2, TextMUh, TextEg1, TextEg2, TextEgh, TextV1, TextV2, TextVh;

        private void textBoxT1_TextChanged(object sender, EventArgs e)
        {
            TextT1 = textBoxT1.Text;
        }

        private void textBoxT2_TextChanged(object sender, EventArgs e)
        {
            TextT2 = textBoxT2.Text;
        }

        private void textBoxTh_TextChanged(object sender, EventArgs e)
        {
            TextTh = textBoxTh.Text;
        }

        private void textBoxMU1_TextChanged(object sender, EventArgs e)
        {
            TextMU1 = textBoxMU1.Text;
        }

        private void textBoxMU2_TextChanged(object sender, EventArgs e)
        {
            TextMU2 = textBoxMU2.Text;
        }

        private void textBoxMUh_TextChanged(object sender, EventArgs e)
        {
            TextMUh = textBoxMUh.Text;
        }

        private void textBoxEg1_TextChanged(object sender, EventArgs e)
        {
            TextEg1 = textBoxEg1.Text;
        }

        private void textBoxEg2_TextChanged(object sender, EventArgs e)
        {
            TextEg2 = textBoxEg2.Text;
        }

        private void textBoxEgh_TextChanged(object sender, EventArgs e)
        {
            TextEgh = textBoxEgh.Text;
        }
        
        private void textBoxV1_TextChanged(object sender, EventArgs e)
        {
            TextV1 = textBoxV1.Text;
        }

        private void textBoxV2_TextChanged(object sender, EventArgs e)
        {
            TextV2 = textBoxV2.Text;
        }

        private void textBoxVh_TextChanged_1(object sender, EventArgs e)
        {
            TextVh = textBoxVh.Text;
        }

        private void textBoxT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void textBoxT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxTh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxMU1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void textBoxMU2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxMUh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxEg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxEg2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxEgh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxV1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void textBoxVh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }



        private void Button_Main_Chart_Click(object sender, EventArgs e)
        {
            if (TextT1 != null)
            {
                T1 = T = Double.Parse(TextT1);
            }
            if (TextT2 != null)
            {
                T2 = Double.Parse(TextT2);
            }
            if (TextTh != null)
            {
                Th = Double.Parse(TextTh);
            }
            if (TextMU1 != null)
            {
                MU1 = MU = Double.Parse(TextMU1);
            }
            if (TextMU2 != null)
            {
                MU2 = Double.Parse(TextMU2);
            }
            if (TextMUh != null)
            {
                MUh = Double.Parse(TextMUh);
            }
            if (TextEg1 != null)
            {
                Eg1 = Eg = Double.Parse(TextEg1);
            }
            if (TextEg2 != null)
            {
                Eg2 = Double.Parse(TextEg2);
            }
            if (TextEgh != null)
            {
                Egh = Double.Parse(TextEgh);
            }
            if (TextV1 != null)
            {
                V1 = V = Double.Parse(TextV1);
            }
            if (TextV2 != null)
            {
                V2 = Double.Parse(TextV2);
            }
            if (TextVh != null)
            {
                Vh = Double.Parse(TextVh);
            }
            this.textBoxT1.Text = T1.ToString();
            this.textBoxT2.Text = T2.ToString();
            this.textBoxTh.Text = Th.ToString();
            this.textBoxMU1.Text = MU1.ToString();
            this.textBoxMU2.Text = MU2.ToString();
            this.textBoxMUh.Text = MUh.ToString();
            this.textBoxEg1.Text = Eg1.ToString();
            this.textBoxEg2.Text = Eg2.ToString();
            this.textBoxEgh.Text = Egh.ToString();
            this.textBoxV1.Text = V1.ToString();
            this.textBoxV2.Text = V2.ToString();
            this.textBoxVh.Text = Vh.ToString();

            this.chart1.Series[0].Points.Clear();

            if (radioButtonT.Checked == true || radioButtonTob.Checked == true)
            {
                C1 = T1;
                C2 = T2;
                Ch = Th;
            }
            else if (radioButtonMU.Checked == true)
            {
                C1 = MU1;
                C2 = MU2;
                Ch = MUh;
            }
            else if (radioButtonEg.Checked == true)
            {
                C1 = Eg1;
                C2 = Eg2;
                Ch = Egh;
            }
            else if (radioButtonV.Checked == true)
            {
                C1 = V1;
                C2 = V2;
                Ch = Vh;
            }
            else { }

            for (C = C1; C <= C2; C += Ch)
            {
                if (radioButtonT.Checked == true)
                {
                    x = T = C;
                }
                else if (radioButtonMU.Checked == true)
                {
                    x = MU = C;
                }
                else if (radioButtonEg.Checked == true)
                {
                    x = Eg = C;
                }
                else if (radioButtonV.Checked == true)
                {
                    x = V = C;
                }
                else if (radioButtonTob.Checked == true)
                {
                    T = C;
                    x = 1 / T;
                }
                else { }

                if (radioButtonG.Checked == true)
                {
                    G = Koef / (k * T) * (SimpsonRule.IntegrateComposite(X => (1 / ((Math.Exp((X - e1 * V) / (k * T))) + (Math.Exp((-X + e1 * V) / (k * T))) + 2)), -1000, (MU - Eg / 2), 200000) + SimpsonRule.IntegrateComposite(X => (1 / ((Math.Exp((X - e1 * V) / (k * T))) + (Math.Exp((-X + e1 * V) / (k * T))) + 2)), (MU + Eg / 2), 1000, 200000));
                    y = G;
                }
                else if (radioButtonGLn.Checked == true)
                {
                    G = Koef / (k * T) * (SimpsonRule.IntegrateComposite(X => (1 / ((Math.Exp((X - e1 * V) / (k * T))) + (Math.Exp((-X + e1 * V) / (k * T))) + 2)), -1000, (MU - Eg / 2), 200000) + SimpsonRule.IntegrateComposite(X => (1 / ((Math.Exp((X - e1 * V) / (k * T))) + (Math.Exp((-X + e1 * V) / (k * T))) + 2)), (MU + Eg / 2), 1000, 200000));
                    y = Math.Log(G);
                }
                else if (radioButtonI.Checked == true)
                {
                    I = -e1*e1 / H * (SimpsonRule.IntegrateComposite(X => (1 / (Math.Exp( X / (k * T)) + 1 ) - (1 / (Math.Exp((X - V) / (k * T)) + 1))), -1000, (MU - Eg / 2), 200000) + SimpsonRule.IntegrateComposite(X => (1 / (Math.Exp(X / (k * T)) + 1) - (1 / (Math.Exp((X - V) / (k * T)) + 1))), (MU + Eg / 2), 1000, 200000));
                    y = I;
                }
                else if (radioButtonILn.Checked == true)
                {
                    I = -e1 * e1 / H * (SimpsonRule.IntegrateComposite(X => (1 / (Math.Exp(X / (k * T)) + 1) - (1 / (Math.Exp((X - V) / (k * T)) + 1))), -1000, (MU - Eg / 2), 200000) + SimpsonRule.IntegrateComposite(X => (1 / (Math.Exp(X / (k * T)) + 1) - (1 / (Math.Exp((X - V) / (k * T)) + 1))), (MU + Eg / 2), 1000, 200000));
                    y = Math.Log(I);
                }
                else { }
                this.chart1.Series[0].Points.AddXY(x, y);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

