using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


//Единицы измерения
//подписать оси

//Тема курсового:
/*
 Принести черновой вариант задания на Курсовой
 Задание: Мат обеспечение программного комплекса по анализу и прогнозированию качества ПП
 -характеристика технологического процесса
 

    -Введение
    -Аналитический обзор
        1.1 характеристика показателей качества
        1.2 характеристика программного обеспечения
        1.3 методы оценки
        2.1 Цель и задачи работы

        3. Основная часть
        3.1  Выбор/модификация алгоритма
        Анализ, алгоритмы, интерфейс,

        4. Выводы по работе
        список источников, содержание,
     */
namespace Lab1_forms_golceva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////Проверка ввода
        ///////////////////////////////////////////////////////////////////////////////////////////////////        
        private void TxtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
        //Проверка ввода только цифр и знаков  
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////Первая часть
        ///////////////////////////////////////////////////////////////////////////////////////////////////
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
        //Мат модель для 1й ступени, 1й части
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
        //Мат модель для 2й ступени, 1й части
        private void Calculate(int N, double M, double C, double V, double G, double tau, double time)
        {
            double step = 0.1;
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
                chart1.ChartAreas[0].AxisX = ax;
                Axis ay = new Axis();
                ay.Title = "Выходная концентрация";
                chart1.ChartAreas[0].AxisY = ay;
            }
            chart1.Series.Add(mySeriesOfPoint);
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
        private void Button4_Click(object sender, EventArgs e)
        {
            //вводимые параметры
            int N = Int16.Parse(txt2_num_cell.Text);
            double V = Double.Parse(txt2_V.Text);
            double G = Double.Parse(txt2_G.Text);
            double Ca_vh = Double.Parse(txt2_Ca_vh.Text);
            //начальные условия
            double Ca0 = Double.Parse(txt2_Ca0.Text);
            double Cb0 = Double.Parse(txt2_Cb0.Text);
            double Cc0 = Double.Parse(txt2_Cc0.Text);
            double K = Double.Parse(txt2_K.Text);
            //
            // хз, надо ли будет использовать double a1 = 1, a2 = 2, a3 = 3;
            //
            //
            if (N > 0 && V > 0 && G > 0 && Ca_vh > 0 && Ca0 >= 0 && Cb0 >= 0 && Cc0 >= 0 && K > 0)
            {

            }
            else
            {
                MessageBox.Show("Все значения должны быть больше нуля!");
            }

        }
        //Запуск 2й части + проверки
    }
}
