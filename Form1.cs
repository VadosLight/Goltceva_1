using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1_forms_golceva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Math_Model(int N, double M, double C, double V, double G, double tau, double time)
        {
            double C_vyh = 0;
            switch (N)
            {
                case 1:
                    C_vyh = C - (1 + (time / tau))
                        * Math.Exp((-time / tau)) * C;
                    break;

                case 2:
                    C_vyh = C - (1 + (time / tau)
                        + 0.5 * Math.Pow((time / tau), 2))
                        * Math.Exp((-time / tau)) * C;
                    break;

                case 3:
                    C_vyh = C - (1 + (time / tau)
                        + 0.5 * Math.Pow((time / tau), 2)
                        + (1 / 6) * Math.Pow((time / tau), 3))
                        * Math.Exp((-time / tau)) * C;
                    break;
            }

            return C_vyh;
        }

        private double Math_Model_2(int N, double M, double C, double V, double G, double tau, double time)
        {
            double C_vyh = 0;
            switch (N)
            {
                case 1:
                    C_vyh = (1 + (time / tau))
                        * Math.Exp((-time / tau)) * C;
                    break;

                case 2:
                    C_vyh = (1 + (time / tau)
                        + 0.5 * Math.Pow((time / tau), 2))
                        * Math.Exp((-time / tau)) * C;
                    break;

                case 3:
                    C_vyh = (1 + (time / tau)
                        + 0.5 * Math.Pow((time / tau), 2)
                        + (1 / 6) * Math.Pow((time / tau), 3))
                        * Math.Exp((-time / tau)) * C;
                    break;
            }

            return C_vyh;
        }
        private void Calculate(int N, double M, double C, double V, double G, double tau, double time)
        {
            double step = 1;
            //===============
            chart1.Series.Clear();
            chart1.Dock = DockStyle.Fill;

            Series mySeriesOfPoint = new Series("Модель реактора");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            //====================
            for (double x = 0; x <= time; x += step)
            {
                double y = Math_Model(N, M, C, V, G, tau, x);
                mySeriesOfPoint.Points.AddXY(x, y);
            }

            double last_С =  Math_Model_2(N, M, C, V, G, tau, time);
            mySeriesOfPoint.Points.AddXY(time, last_С);
            C = last_С;

            for (double x = 0; x <= time; x += step)
            {
                double y = Math_Model_2(N, M, C, V, G, tau, x);
                mySeriesOfPoint.Points.AddXY(x+time, y);
            }

            //====================
            {
                Axis ax = new Axis();
                ax.Title = "Время";
                chart1.ChartAreas[0].AxisX = ax;
                Axis ay = new Axis();
                ay.Title = "Выходная концентрация";
                chart1.ChartAreas[0].AxisY = ay;
            }
            chart1.Series.Add(mySeriesOfPoint);
        }

        private void TxtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Int16.Parse(txtN.Text);
                double C = Double.Parse(txtC.Text);
                double V = Double.Parse(txtV.Text);
                double G = Double.Parse(txtG.Text);
                double M = Double.Parse(txtM.Text);
                double tau = 0;
                double time = 0;


                if (G != 0 && V != 0 && M > 0)
                {
                    tau = V / G;
                    time = tau * M;
                }
                else
                {
                    MessageBox.Show("Деление на ноль");
                    return;
                }

                if (1 <= N && N <= 3)
                {
                    Calculate(N, M, C, V, G, tau, time);
                }
                else
                {
                    MessageBox.Show("N должно быть от 1 до 3");
                    return;
                }


            }
            catch
            {
                MessageBox.Show("При вводе данных возникла ошибка");
            }
        }
    }
}
