namespace Lab1_forms_golceva
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtV = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt2_K = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt2_Cb0 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt2_Ca0 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt2_Cc0 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt2_Ca_vh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt2_G = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt2_V = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt2_num_cell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtM);
            this.tabPage1.Controls.Add(this.txtG);
            this.tabPage1.Controls.Add(this.txtV);
            this.tabPage1.Controls.Add(this.txtC);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtN);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(780, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аналитическая модель";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Открыть задание";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(324, 130);
            this.txtM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(179, 22);
            this.txtM.TabIndex = 9;
            this.txtM.Text = "5";
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(324, 102);
            this.txtG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(179, 22);
            this.txtG.TabIndex = 8;
            this.txtG.Text = "15";
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(324, 70);
            this.txtV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(179, 22);
            this.txtV.TabIndex = 7;
            this.txtV.Text = "15";
            this.txtV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(324, 39);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(179, 22);
            this.txtC.TabIndex = 6;
            this.txtC.Text = "10";
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(8, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "M коээфициент продолжительности реакции";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(324, 11);
            this.txtN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(179, 22);
            this.txtN.TabIndex = 4;
            this.txtN.Text = "1";
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "G объемный расход, м^3/Ч";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "V объем аппарата, м^3";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "C(вх) концентрация входная, Кмоль/м^3";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "N число ячеек в реакторе";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(780, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(774, 414);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.txt2_Ca_vh);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txt2_G);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txt2_V);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt2_num_cell);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(780, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Численная модель";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt2_K);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt2_Cb0);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt2_Ca0);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt2_Cc0);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(8, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 136);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальные условия";
            // 
            // txt2_K
            // 
            this.txt2_K.Location = new System.Drawing.Point(316, 98);
            this.txt2_K.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2_K.MaxLength = 5;
            this.txt2_K.Name = "txt2_K";
            this.txt2_K.Size = new System.Drawing.Size(179, 22);
            this.txt2_K.TabIndex = 13;
            this.txt2_K.Text = "0,8";
            this.txt2_K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(0, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(310, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "K";
            // 
            // txt2_Cb0
            // 
            this.txt2_Cb0.Location = new System.Drawing.Point(316, 46);
            this.txt2_Cb0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2_Cb0.MaxLength = 5;
            this.txt2_Cb0.Name = "txt2_Cb0";
            this.txt2_Cb0.Size = new System.Drawing.Size(179, 22);
            this.txt2_Cb0.TabIndex = 11;
            this.txt2_Cb0.Text = "3";
            this.txt2_Cb0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(0, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(310, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cb0";
            // 
            // txt2_Ca0
            // 
            this.txt2_Ca0.Location = new System.Drawing.Point(316, 20);
            this.txt2_Ca0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2_Ca0.MaxLength = 5;
            this.txt2_Ca0.Name = "txt2_Ca0";
            this.txt2_Ca0.Size = new System.Drawing.Size(179, 22);
            this.txt2_Ca0.TabIndex = 9;
            this.txt2_Ca0.Text = "2";
            this.txt2_Ca0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(0, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(310, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Са0";
            // 
            // txt2_Cc0
            // 
            this.txt2_Cc0.Location = new System.Drawing.Point(316, 72);
            this.txt2_Cc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2_Cc0.MaxLength = 5;
            this.txt2_Cc0.Name = "txt2_Cc0";
            this.txt2_Cc0.Size = new System.Drawing.Size(179, 22);
            this.txt2_Cc0.TabIndex = 7;
            this.txt2_Cc0.Text = "2";
            this.txt2_Cc0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(0, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(310, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cc0";
            // 
            // txt2_Ca_vh
            // 
            this.txt2_Ca_vh.Location = new System.Drawing.Point(319, 82);
            this.txt2_Ca_vh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2_Ca_vh.MaxLength = 5;
            this.txt2_Ca_vh.Name = "txt2_Ca_vh";
            this.txt2_Ca_vh.Size = new System.Drawing.Size(179, 22);
            this.txt2_Ca_vh.TabIndex = 11;
            this.txt2_Ca_vh.Text = "5";
            this.txt2_Ca_vh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(3, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ca входная";
            // 
            // txt2_G
            // 
            this.txt2_G.Location = new System.Drawing.Point(319, 56);
            this.txt2_G.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2_G.MaxLength = 5;
            this.txt2_G.Name = "txt2_G";
            this.txt2_G.Size = new System.Drawing.Size(179, 22);
            this.txt2_G.TabIndex = 9;
            this.txt2_G.Text = "2";
            this.txt2_G.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "G";
            // 
            // txt2_V
            // 
            this.txt2_V.Location = new System.Drawing.Point(319, 30);
            this.txt2_V.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2_V.MaxLength = 5;
            this.txt2_V.Name = "txt2_V";
            this.txt2_V.Size = new System.Drawing.Size(179, 22);
            this.txt2_V.TabIndex = 7;
            this.txt2_V.Text = "3";
            this.txt2_V.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "V";
            // 
            // txt2_num_cell
            // 
            this.txt2_num_cell.Location = new System.Drawing.Point(319, 4);
            this.txt2_num_cell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt2_num_cell.MaxLength = 5;
            this.txt2_num_cell.Name = "txt2_num_cell";
            this.txt2_num_cell.Size = new System.Drawing.Size(179, 22);
            this.txt2_num_cell.TabIndex = 5;
            this.txt2_num_cell.Text = "1";
            this.txt2_num_cell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtN_KeyPress);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "N число ячеек в реакторе";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 51);
            this.button3.TabIndex = 14;
            this.button3.Text = "Открыть задание";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 271);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "Расчёт";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Компьютерное моделирование в химии и химической технологии";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt2_num_cell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt2_V;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt2_K;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt2_Cb0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt2_Ca0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt2_Cc0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt2_Ca_vh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt2_G;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

