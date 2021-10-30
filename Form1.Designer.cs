namespace Integral_Grafiki
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.radioButtonT = new System.Windows.Forms.RadioButton();
            this.radioButtonMU = new System.Windows.Forms.RadioButton();
            this.radioButtonEg = new System.Windows.Forms.RadioButton();
            this.radioButtonV = new System.Windows.Forms.RadioButton();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.radioButtonGLn = new System.Windows.Forms.RadioButton();
            this.radioButtonI = new System.Windows.Forms.RadioButton();
            this.radioButtonILn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTob = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxT1 = new System.Windows.Forms.TextBox();
            this.textBoxT2 = new System.Windows.Forms.TextBox();
            this.textBoxTh = new System.Windows.Forms.TextBox();
            this.textBoxMU1 = new System.Windows.Forms.TextBox();
            this.textBoxMU2 = new System.Windows.Forms.TextBox();
            this.textBoxMUh = new System.Windows.Forms.TextBox();
            this.textBoxEg1 = new System.Windows.Forms.TextBox();
            this.textBoxEg2 = new System.Windows.Forms.TextBox();
            this.textBoxEgh = new System.Windows.Forms.TextBox();
            this.textBoxV1 = new System.Windows.Forms.TextBox();
            this.textBoxV2 = new System.Windows.Forms.TextBox();
            this.textBoxVh = new System.Windows.Forms.TextBox();
            this.Button_Main_Chart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(214, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1014, 722);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "График";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Начальная Т:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(24, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "К";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Конечная Т:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(184, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(24, 20);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "К";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 90);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(97, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Начальная Мю:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 168);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 20);
            this.textBox9.TabIndex = 10;
            this.textBox9.Text = "Начальная Eg:";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(6, 246);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(97, 20);
            this.textBox11.TabIndex = 12;
            this.textBox11.Text = "Начальная V:";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(184, 90);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(24, 20);
            this.textBox13.TabIndex = 14;
            this.textBox13.Text = "Эв";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(184, 220);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(24, 20);
            this.textBox14.TabIndex = 15;
            this.textBox14.Text = "Эв";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(184, 246);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(24, 20);
            this.textBox15.TabIndex = 16;
            this.textBox15.Text = "В";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(6, 64);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(82, 20);
            this.textBox16.TabIndex = 17;
            this.textBox16.Text = "Шаг Т";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(184, 64);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(24, 20);
            this.textBox18.TabIndex = 19;
            this.textBox18.Text = "К";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(184, 116);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(24, 20);
            this.textBox19.TabIndex = 22;
            this.textBox19.Text = "Эв";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(184, 142);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(24, 20);
            this.textBox20.TabIndex = 23;
            this.textBox20.Text = "Эв";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(184, 168);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(24, 20);
            this.textBox21.TabIndex = 24;
            this.textBox21.Text = "Эв";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(184, 194);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(24, 20);
            this.textBox22.TabIndex = 25;
            this.textBox22.Text = "Эв";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(6, 116);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(97, 20);
            this.textBox25.TabIndex = 28;
            this.textBox25.Text = "Конечная Мю:";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(6, 142);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(97, 20);
            this.textBox26.TabIndex = 29;
            this.textBox26.Text = "Шаг Мю";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(6, 194);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(82, 20);
            this.textBox27.TabIndex = 30;
            this.textBox27.Text = "Конечная Eg:";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(6, 220);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(82, 20);
            this.textBox28.TabIndex = 31;
            this.textBox28.Text = "Шаг Eg:";
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(6, 272);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(97, 20);
            this.textBox31.TabIndex = 34;
            this.textBox31.Text = "Конечная V:";
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(6, 298);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(97, 20);
            this.textBox32.TabIndex = 35;
            this.textBox32.Text = "Шаг V:";
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(184, 272);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(24, 20);
            this.textBox35.TabIndex = 38;
            this.textBox35.Text = "В";
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(184, 298);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(24, 20);
            this.textBox36.TabIndex = 39;
            this.textBox36.Text = "В";
            // 
            // radioButtonT
            // 
            this.radioButtonT.AutoSize = true;
            this.radioButtonT.Location = new System.Drawing.Point(6, 19);
            this.radioButtonT.Name = "radioButtonT";
            this.radioButtonT.Size = new System.Drawing.Size(32, 17);
            this.radioButtonT.TabIndex = 40;
            this.radioButtonT.TabStop = true;
            this.radioButtonT.Text = "T";
            this.radioButtonT.UseVisualStyleBackColor = true;
            // 
            // radioButtonMU
            // 
            this.radioButtonMU.AutoSize = true;
            this.radioButtonMU.Location = new System.Drawing.Point(6, 42);
            this.radioButtonMU.Name = "radioButtonMU";
            this.radioButtonMU.Size = new System.Drawing.Size(42, 17);
            this.radioButtonMU.TabIndex = 41;
            this.radioButtonMU.TabStop = true;
            this.radioButtonMU.Text = "MU";
            this.radioButtonMU.UseVisualStyleBackColor = true;
            // 
            // radioButtonEg
            // 
            this.radioButtonEg.AutoSize = true;
            this.radioButtonEg.Location = new System.Drawing.Point(6, 65);
            this.radioButtonEg.Name = "radioButtonEg";
            this.radioButtonEg.Size = new System.Drawing.Size(38, 17);
            this.radioButtonEg.TabIndex = 42;
            this.radioButtonEg.TabStop = true;
            this.radioButtonEg.Text = "Eg";
            this.radioButtonEg.UseVisualStyleBackColor = true;
            // 
            // radioButtonV
            // 
            this.radioButtonV.AutoSize = true;
            this.radioButtonV.Location = new System.Drawing.Point(6, 88);
            this.radioButtonV.Name = "radioButtonV";
            this.radioButtonV.Size = new System.Drawing.Size(32, 17);
            this.radioButtonV.TabIndex = 43;
            this.radioButtonV.TabStop = true;
            this.radioButtonV.Text = "V";
            this.radioButtonV.UseVisualStyleBackColor = true;
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(6, 19);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(33, 17);
            this.radioButtonG.TabIndex = 44;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "G";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // radioButtonGLn
            // 
            this.radioButtonGLn.AutoSize = true;
            this.radioButtonGLn.Location = new System.Drawing.Point(6, 42);
            this.radioButtonGLn.Name = "radioButtonGLn";
            this.radioButtonGLn.Size = new System.Drawing.Size(51, 17);
            this.radioButtonGLn.TabIndex = 45;
            this.radioButtonGLn.TabStop = true;
            this.radioButtonGLn.Text = "Ln(G)";
            this.radioButtonGLn.UseVisualStyleBackColor = true;
            // 
            // radioButtonI
            // 
            this.radioButtonI.AutoSize = true;
            this.radioButtonI.Location = new System.Drawing.Point(6, 65);
            this.radioButtonI.Name = "radioButtonI";
            this.radioButtonI.Size = new System.Drawing.Size(28, 17);
            this.radioButtonI.TabIndex = 46;
            this.radioButtonI.TabStop = true;
            this.radioButtonI.Text = "I";
            this.radioButtonI.UseVisualStyleBackColor = true;
            // 
            // radioButtonILn
            // 
            this.radioButtonILn.AutoSize = true;
            this.radioButtonILn.Location = new System.Drawing.Point(6, 88);
            this.radioButtonILn.Name = "radioButtonILn";
            this.radioButtonILn.Size = new System.Drawing.Size(46, 17);
            this.radioButtonILn.TabIndex = 47;
            this.radioButtonILn.TabStop = true;
            this.radioButtonILn.Text = "Ln(I)";
            this.radioButtonILn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTob);
            this.groupBox1.Controls.Add(this.radioButtonT);
            this.groupBox1.Controls.Add(this.radioButtonMU);
            this.groupBox1.Controls.Add(this.radioButtonEg);
            this.groupBox1.Controls.Add(this.radioButtonV);
            this.groupBox1.Location = new System.Drawing.Point(6, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 137);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ось X";
            // 
            // radioButtonTob
            // 
            this.radioButtonTob.AutoSize = true;
            this.radioButtonTob.Location = new System.Drawing.Point(6, 111);
            this.radioButtonTob.Name = "radioButtonTob";
            this.radioButtonTob.Size = new System.Drawing.Size(43, 17);
            this.radioButtonTob.TabIndex = 68;
            this.radioButtonTob.TabStop = true;
            this.radioButtonTob.Text = "1/T";
            this.radioButtonTob.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonG);
            this.groupBox2.Controls.Add(this.radioButtonGLn);
            this.groupBox2.Controls.Add(this.radioButtonI);
            this.groupBox2.Controls.Add(this.radioButtonILn);
            this.groupBox2.Location = new System.Drawing.Point(109, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 137);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ось Y";
            // 
            // textBoxT1
            // 
            this.textBoxT1.Location = new System.Drawing.Point(94, 12);
            this.textBoxT1.Name = "textBoxT1";
            this.textBoxT1.Size = new System.Drawing.Size(84, 20);
            this.textBoxT1.TabIndex = 48;
            this.textBoxT1.Text = "300";
            this.textBoxT1.TextChanged += new System.EventHandler(this.textBoxT1_TextChanged);
            this.textBoxT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxT1_KeyPress);
            // 
            // textBoxT2
            // 
            this.textBoxT2.Location = new System.Drawing.Point(94, 38);
            this.textBoxT2.Name = "textBoxT2";
            this.textBoxT2.Size = new System.Drawing.Size(84, 20);
            this.textBoxT2.TabIndex = 52;
            this.textBoxT2.Text = "1000";
            this.textBoxT2.TextChanged += new System.EventHandler(this.textBoxT2_TextChanged);
            this.textBoxT2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxT2_KeyPress);
            // 
            // textBoxTh
            // 
            this.textBoxTh.Location = new System.Drawing.Point(94, 64);
            this.textBoxTh.Name = "textBoxTh";
            this.textBoxTh.Size = new System.Drawing.Size(84, 20);
            this.textBoxTh.TabIndex = 53;
            this.textBoxTh.Text = "100";
            this.textBoxTh.TextChanged += new System.EventHandler(this.textBoxTh_TextChanged);
            this.textBoxTh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTh_KeyPress);
            // 
            // textBoxMU1
            // 
            this.textBoxMU1.Location = new System.Drawing.Point(109, 90);
            this.textBoxMU1.Name = "textBoxMU1";
            this.textBoxMU1.Size = new System.Drawing.Size(69, 20);
            this.textBoxMU1.TabIndex = 54;
            this.textBoxMU1.Text = "0";
            this.textBoxMU1.TextChanged += new System.EventHandler(this.textBoxMU1_TextChanged);
            this.textBoxMU1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMU1_KeyPress);
            // 
            // textBoxMU2
            // 
            this.textBoxMU2.Location = new System.Drawing.Point(109, 116);
            this.textBoxMU2.Name = "textBoxMU2";
            this.textBoxMU2.Size = new System.Drawing.Size(69, 20);
            this.textBoxMU2.TabIndex = 55;
            this.textBoxMU2.Text = "5";
            this.textBoxMU2.TextChanged += new System.EventHandler(this.textBoxMU2_TextChanged);
            this.textBoxMU2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMU2_KeyPress);
            // 
            // textBoxMUh
            // 
            this.textBoxMUh.Location = new System.Drawing.Point(109, 142);
            this.textBoxMUh.Name = "textBoxMUh";
            this.textBoxMUh.Size = new System.Drawing.Size(69, 20);
            this.textBoxMUh.TabIndex = 59;
            this.textBoxMUh.Text = "1";
            this.textBoxMUh.TextChanged += new System.EventHandler(this.textBoxMUh_TextChanged);
            this.textBoxMUh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMUh_KeyPress);
            // 
            // textBoxEg1
            // 
            this.textBoxEg1.Location = new System.Drawing.Point(94, 168);
            this.textBoxEg1.Name = "textBoxEg1";
            this.textBoxEg1.Size = new System.Drawing.Size(84, 20);
            this.textBoxEg1.TabIndex = 60;
            this.textBoxEg1.Text = "0";
            this.textBoxEg1.TextChanged += new System.EventHandler(this.textBoxEg1_TextChanged);
            this.textBoxEg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEg1_KeyPress);
            // 
            // textBoxEg2
            // 
            this.textBoxEg2.Location = new System.Drawing.Point(94, 194);
            this.textBoxEg2.Name = "textBoxEg2";
            this.textBoxEg2.Size = new System.Drawing.Size(84, 20);
            this.textBoxEg2.TabIndex = 61;
            this.textBoxEg2.Text = "5";
            this.textBoxEg2.TextChanged += new System.EventHandler(this.textBoxEg2_TextChanged);
            this.textBoxEg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEg2_KeyPress);
            // 
            // textBoxEgh
            // 
            this.textBoxEgh.Location = new System.Drawing.Point(94, 220);
            this.textBoxEgh.Name = "textBoxEgh";
            this.textBoxEgh.Size = new System.Drawing.Size(84, 20);
            this.textBoxEgh.TabIndex = 62;
            this.textBoxEgh.Text = "1";
            this.textBoxEgh.TextChanged += new System.EventHandler(this.textBoxEgh_TextChanged);
            this.textBoxEgh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEgh_KeyPress);
            // 
            // textBoxV1
            // 
            this.textBoxV1.Location = new System.Drawing.Point(109, 246);
            this.textBoxV1.Name = "textBoxV1";
            this.textBoxV1.Size = new System.Drawing.Size(69, 20);
            this.textBoxV1.TabIndex = 64;
            this.textBoxV1.Text = "0";
            this.textBoxV1.TextChanged += new System.EventHandler(this.textBoxV1_TextChanged);
            this.textBoxV1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV1_KeyPress);
            // 
            // textBoxV2
            // 
            this.textBoxV2.Location = new System.Drawing.Point(109, 272);
            this.textBoxV2.Name = "textBoxV2";
            this.textBoxV2.Size = new System.Drawing.Size(69, 20);
            this.textBoxV2.TabIndex = 65;
            this.textBoxV2.Text = "1000";
            this.textBoxV2.TextChanged += new System.EventHandler(this.textBoxV2_TextChanged);
            this.textBoxV2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV2_KeyPress);
            // 
            // textBoxVh
            // 
            this.textBoxVh.Location = new System.Drawing.Point(109, 298);
            this.textBoxVh.Name = "textBoxVh";
            this.textBoxVh.Size = new System.Drawing.Size(69, 20);
            this.textBoxVh.TabIndex = 66;
            this.textBoxVh.Text = "100";
            this.textBoxVh.TextChanged += new System.EventHandler(this.textBoxVh_TextChanged_1);
            this.textBoxVh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVh_KeyPress);
            // 
            // Button_Main_Chart
            // 
            this.Button_Main_Chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Main_Chart.Location = new System.Drawing.Point(4, 671);
            this.Button_Main_Chart.Name = "Button_Main_Chart";
            this.Button_Main_Chart.Size = new System.Drawing.Size(204, 63);
            this.Button_Main_Chart.TabIndex = 67;
            this.Button_Main_Chart.Text = "Построить график";
            this.Button_Main_Chart.UseVisualStyleBackColor = true;
            this.Button_Main_Chart.Click += new System.EventHandler(this.Button_Main_Chart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 746);
            this.Controls.Add(this.Button_Main_Chart);
            this.Controls.Add(this.textBoxVh);
            this.Controls.Add(this.textBoxV2);
            this.Controls.Add(this.textBoxV1);
            this.Controls.Add(this.textBoxEgh);
            this.Controls.Add(this.textBoxEg2);
            this.Controls.Add(this.textBoxEg1);
            this.Controls.Add(this.textBoxMUh);
            this.Controls.Add(this.textBoxMU2);
            this.Controls.Add(this.textBoxMU1);
            this.Controls.Add(this.textBoxTh);
            this.Controls.Add(this.textBoxT2);
            this.Controls.Add(this.textBoxT1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox36);
            this.Controls.Add(this.textBox35);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.RadioButton radioButtonT;
        private System.Windows.Forms.RadioButton radioButtonMU;
        private System.Windows.Forms.RadioButton radioButtonEg;
        private System.Windows.Forms.RadioButton radioButtonV;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.RadioButton radioButtonGLn;
        private System.Windows.Forms.RadioButton radioButtonI;
        private System.Windows.Forms.RadioButton radioButtonILn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxT1;
        private System.Windows.Forms.TextBox textBoxT2;
        private System.Windows.Forms.TextBox textBoxTh;
        private System.Windows.Forms.TextBox textBoxMU1;
        private System.Windows.Forms.TextBox textBoxMU2;
        private System.Windows.Forms.TextBox textBoxMUh;
        private System.Windows.Forms.TextBox textBoxEg1;
        private System.Windows.Forms.TextBox textBoxEg2;
        private System.Windows.Forms.TextBox textBoxEgh;
        private System.Windows.Forms.TextBox textBoxV1;
        private System.Windows.Forms.TextBox textBoxV2;
        private System.Windows.Forms.TextBox textBoxVh;
        private System.Windows.Forms.Button Button_Main_Chart;
        private System.Windows.Forms.RadioButton radioButtonTob;
    }
}

