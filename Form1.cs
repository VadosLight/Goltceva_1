using System;
using System.Diagnostics;
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
      
        private void TxtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        //Мат модель для 1й ступени, 1й части
        private double Math_Model(int N, double M, double C, double V, double G, double tau, double x)
        {
            double C_vyh = 0;
            switch (N)
            {
                case 1:
                    C_vyh = (1 - Math.Exp((-x / tau))) * C;
                    break;

                case 2:
                    C_vyh = C - (1 + (x / tau)) * C * Math.Exp((-x / tau));
                    break;

                case 3:
                    C_vyh = C - (1 + (x / tau) + 0.5 * Math.Pow((x / tau), 2)) * C * Math.Exp((-x / tau));

                    break;
            }

            return C_vyh;
        }
        //Мат модель для 2й ступени, 1й части
        private double Math_Model_2(int N, double M, double C, double V, double G, double tau, double x)
        {
            double C_vyh = 0;

            switch (N)
            {
                case 1:
                    C_vyh = Math.Exp((-x / tau)) * C;
                    break;

                case 2:
                    C_vyh = (1 + (x / tau)) * Math.Exp((-x / tau)) * C;
                    break;

                case 3:
                    C_vyh = (1 + (x / tau) + 0.5 * Math.Pow((x / tau), 2)) * Math.Exp((-x / tau)) * C;

                    break;
            }

            return C_vyh;
        }
        private void Calculate(int N, double M, double C, double V, double G, double tau, double time)
        {
            double step = 0.1;
            //===============
            
            chart5.Series.Clear();
            chart5.Dock = DockStyle.Fill;

            Series mySeriesOfPoint = new Series("Модель реактора");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            //====================
            for (double x = 0; x <= time; x += step)
            {
                double y = Math_Model(N, M, C, V, G, tau, x);
                mySeriesOfPoint.Points.AddXY(x, y);
            }


            //C = 10;

            for (double x2 = 0; x2 <= time; x2 += step)
            {
                double y = Math_Model_2(N, M, C, V, G, tau, x2);
                mySeriesOfPoint.Points.AddXY(x2 + time, y);
            }

            //====================
            {
                Axis ax = new Axis();
                ax.Title = "Время";
                chart5.ChartAreas[0].AxisX = ax;
                Axis ay = new Axis();
                ay.Title = "Выходная концентрация";
                chart5.ChartAreas[0].AxisY = ay;
            }
            chart5.Series.Add(mySeriesOfPoint);
        }
        //Алгоритм для вычисления 1й части
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
        //Запуск 1й части + проверки
        private void Button2_Click(object sender, EventArgs e)
        {
            //Открываем фотографию с прикрепленным документом
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string filePath = startupPath + "\\img\\1.jpg";
            Process.Start(filePath);
        }
        //Вывод изображения с 1й частью 

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////Начинаем вторую часть
        ///////////////////////////////////////////////////////////////////////////////////////////////////  
        private void Button3_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string filePath = startupPath + "\\img\\2.jpg";
            Process.Start(filePath);
        }
        //Вывод изображения с 2й частью 

        private void Button5_Click(object sender, EventArgs e)
        {
            int n = 0, m = 0;
            double k1 = 0, caIn = 0, ca0 = 0, cb0 = 0, cc0 = 0, ca2 = 0, cb2 = 0, cc2 = 0, tau = 0, v = 0, g = 0;
            double a_1 = 0, a_2 = 0, a_3 = 0;

            dgw.Rows.Clear();
            chart1.Series["Ca"].Points.Clear();
            chart1.Series["Cb"].Points.Clear();
            chart1.Series["Cc"].Points.Clear();

            dgw2.Rows.Clear();
            chart2.Series["Ca2"].Points.Clear();
            chart2.Series["Cb2"].Points.Clear();
            chart2.Series["Cc2"].Points.Clear();


            try {
                n = Convert.ToInt16(cbN.Text);
                k1 = Convert.ToDouble(tbK1.Text);
                caIn = Convert.ToDouble(tbCAin.Text);
                ca0 = Convert.ToDouble(tbCa0.Text);
                cb0 = Convert.ToDouble(tbCb0.Text);
                cc0 = Convert.ToDouble(tbCc0.Text);
                ca2 = Convert.ToDouble(tbCa2.Text);
                cb2 = Convert.ToDouble(tbCb2.Text);
                cc2 = Convert.ToDouble(tbCc2.Text);
                m = Convert.ToInt16(cbM.Text);
                v = Convert.ToDouble(tbV.Text);
                g = Convert.ToDouble(tbG.Text);
                tau = v / g;
                a_1 = Convert.ToDouble(a1.Text);
                a_2 = Convert.ToDouble(a2.Text);
                a_3 = Convert.ToDouble(a3.Text);
            }
            catch { }


            if (n == 1 || n == 2)
                if (k1 >= 0.8 && k1 <= 1)
                    if (caIn >= 1 && caIn <= 5)
                        if (ca0 >= 0 && ca0 <= 3)
                            if (cb0 >= 0 && cb0 <= 5)
                                if (cc0 >= 0 && cc0 <= 3)
                                    if (ca2 >= 0 && ca0 <= 3)
                                        if (cb2 >= 0 && cb0 <= 5)
                                            if (cc2 >= 0 && cc0 <= 3)
                                                if (v >= 1 && v <= 5)
                                                    if (g > 0.5 && g <= 5)
                                                        if (m == 3 || m == 4 || m == 5)
                                                        {
                                                            lbErr.Text = "";
                                                            lblTau.Text = "τ = " + Math.Round(tau, 3);

                                                            if (n == 1 || n == 2)
                                                            {
                                                                double caNext = ca0;
                                                                double cbNext = cb0;
                                                                double ccNext = cc0;

                                                                double ca2Next = 0, cb2Next = 0, cc2Next = 0;

                                                                dgw.Columns.Add("t", "t");
                                                                dgw.Columns.Add("CA", "CA");
                                                                dgw.Columns.Add("CB", "CB");
                                                                dgw.Columns.Add("CC", "CC");

                                                                dgw.Rows.Add("0", caNext, cbNext, ccNext);

                                                                chart1.Series["Ca"].Points.AddXY(0, caNext);
                                                                chart1.Series["Cb"].Points.AddXY(0, cbNext);
                                                                chart1.Series["Cc"].Points.AddXY(0, ccNext);

                                                                if (n == 2)
                                                                {
                                                                    ca2Next = ca2;
                                                                    cb2Next = cb2;
                                                                    cc2Next = cc2;

                                                                    dgw2.Columns.Add("t", "t");
                                                                    dgw2.Columns.Add("CA2", "CA2");
                                                                    dgw2.Columns.Add("CB2", "CB2");
                                                                    dgw2.Columns.Add("CC2", "CC2");

                                                                    dgw2.Rows.Add("0", ca2Next, cb2Next, cc2Next);

                                                                    chart2.Series["Ca2"].Points.AddXY(0, ca2Next);
                                                                    chart2.Series["Cb2"].Points.AddXY(0, cb2Next);
                                                                    chart2.Series["Cc2"].Points.AddXY(0, cc2Next);
                                                                }

                                                                for (int i = 1; i < m * tau; i++)
                                                                {
                                                                    cbNext = cbNext + (1 / tau) * ((0 - cbNext) + a_2 * k1 * caNext);//бетта
                                                                    ccNext = ccNext + (1 / tau) * ((0 - ccNext) + a_3 * k1 * caNext);//гамма вместо 2
                                                                    caNext = caNext + (1 / tau) * ((caIn - caNext) - a_1 * k1 * caNext);//альфа

                                                                    dgw.Rows.Add(i + 1, Math.Round(caNext, 3), Math.Round(cbNext, 3), Math.Round(ccNext, 3));

                                                                    chart1.Series["Ca"].Points.AddXY(i - 1, caNext);
                                                                    chart1.Series["Cb"].Points.AddXY(i - 1, cbNext);
                                                                    chart1.Series["Cc"].Points.AddXY(i - 1, ccNext);

                                                                    if (n == 2)
                                                                    {
                                                                        cb2Next = cb2Next + (1 / tau) * ((cbNext - cb2Next) + a_2 * k1 * ca2Next);
                                                                        cc2Next = cc2Next + (1 / tau) * ((ccNext - cc2Next) + a_3 * k1 * ca2Next);
                                                                        ca2Next = ca2Next + (1 / tau) * ((caNext - ca2Next) - a_1 * k1 * ca2Next);

                                                                        dgw2.Rows.Add(i + 1, Math.Round(ca2Next, 3), Math.Round(cb2Next, 3), Math.Round(cc2Next, 3));
                                                                        chart2.Series["Ca2"].Points.AddXY(i - 1, ca2Next);
                                                                        chart2.Series["Cb2"].Points.AddXY(i - 1, cb2Next);
                                                                        chart2.Series["Cc2"].Points.AddXY(i - 1, cc2Next);
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else
                                                            lbErr.Text = "M = 3, 4 или 5";
                                                    else
                                                        lbErr.Text = "0,5 <= G <= 5";
                                                else
                                                    lbErr.Text = "1 <= V <= 5";
                                            else
                                                lbErr.Text = "0 < Cc0 <= 3";
                                        else
                                            lbErr.Text = "0 < Cb0 <= 5";
                                    else
                                        lbErr.Text = "0 < Ca0 <= 3";
                                else
                                    lbErr.Text = "1 <= CAвх <= 5";
                            else
                                lbErr.Text = "0,8 <= K1 <= 1";
                        else
                            lbErr.Text = "N = 1 или 2";

        }
    }
}
