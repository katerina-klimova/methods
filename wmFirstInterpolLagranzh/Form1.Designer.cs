namespace wmFirstInterpolLagranzh
{
    partial class InterpolForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chFunk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chError = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.btnDraw = new System.Windows.Forms.Button();
            this.rbUniform = new System.Windows.Forms.RadioButton();
            this.rbCheb = new System.Windows.Forms.RadioButton();
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.dgvN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCheb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbSqrt = new System.Windows.Forms.RadioButton();
            this.rbSin = new System.Windows.Forms.RadioButton();
            this.rbWOSqrt = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbRazb = new System.Windows.Forms.GroupBox();
            this.gbFunc = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chFunk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            this.gbRazb.SuspendLayout();
            this.gbFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // chFunk
            // 
            chartArea3.CursorX.AxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chartArea3.CursorX.SelectionEnd = 1D;
            chartArea3.CursorX.SelectionStart = -1D;
            chartArea3.Name = "ChartArea1";
            this.chFunk.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chFunk.Legends.Add(legend3);
            this.chFunk.Location = new System.Drawing.Point(12, 66);
            this.chFunk.Name = "chFunk";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chFunk.Series.Add(series3);
            this.chFunk.Size = new System.Drawing.Size(409, 387);
            this.chFunk.TabIndex = 0;
            this.chFunk.Text = "chart1";
            // 
            // chError
            // 
            chartArea4.Name = "ChartArea1";
            this.chError.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chError.Legends.Add(legend4);
            this.chError.Location = new System.Drawing.Point(473, 66);
            this.chError.Name = "chError";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chError.Series.Add(series4);
            this.chError.Size = new System.Drawing.Size(399, 387);
            this.chError.TabIndex = 1;
            this.chError.Text = "chart1";
            this.chError.Click += new System.EventHandler(this.chError_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "График функции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "График погрешности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(995, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Степень полинома:";
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(998, 99);
            this.nudN.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(122, 20);
            this.nudN.TabIndex = 5;
            this.nudN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.ValueChanged += new System.EventHandler(this.nudN_ValueChanged);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(998, 143);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(122, 23);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Рисовать график";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // rbUniform
            // 
            this.rbUniform.AutoSize = true;
            this.rbUniform.Location = new System.Drawing.Point(6, 33);
            this.rbUniform.Name = "rbUniform";
            this.rbUniform.Size = new System.Drawing.Size(94, 17);
            this.rbUniform.TabIndex = 7;
            this.rbUniform.TabStop = true;
            this.rbUniform.Text = "Равномерное";
            this.rbUniform.UseVisualStyleBackColor = true;
            // 
            // rbCheb
            // 
            this.rbCheb.AutoSize = true;
            this.rbCheb.Location = new System.Drawing.Point(6, 69);
            this.rbCheb.Name = "rbCheb";
            this.rbCheb.Size = new System.Drawing.Size(97, 17);
            this.rbCheb.TabIndex = 8;
            this.rbCheb.TabStop = true;
            this.rbCheb.Text = "Чебышевское";
            this.rbCheb.UseVisualStyleBackColor = true;
            // 
            // dgvError
            // 
            this.dgvError.AllowUserToAddRows = false;
            this.dgvError.AllowUserToDeleteRows = false;
            this.dgvError.AllowUserToResizeColumns = false;
            this.dgvError.AllowUserToResizeRows = false;
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvN,
            this.dgvUnif,
            this.dgvCheb});
            this.dgvError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvError.Location = new System.Drawing.Point(998, 274);
            this.dgvError.Name = "dgvError";
            this.dgvError.ReadOnly = true;
            this.dgvError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvError.Size = new System.Drawing.Size(303, 286);
            this.dgvError.TabIndex = 10;
            // 
            // dgvN
            // 
            this.dgvN.HeaderText = "N";
            this.dgvN.Name = "dgvN";
            this.dgvN.ReadOnly = true;
            this.dgvN.Width = 40;
            // 
            // dgvUnif
            // 
            this.dgvUnif.HeaderText = "Равноемерное";
            this.dgvUnif.Name = "dgvUnif";
            this.dgvUnif.ReadOnly = true;
            // 
            // dgvCheb
            // 
            this.dgvCheb.HeaderText = "Чебышевское";
            this.dgvCheb.Name = "dgvCheb";
            this.dgvCheb.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(995, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Таблица погрешностей: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "sqrt(5*x^2+2)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "sqtr(3*x^2+1)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "--------------------";
            // 
            // rbSqrt
            // 
            this.rbSqrt.AutoSize = true;
            this.rbSqrt.Location = new System.Drawing.Point(35, 29);
            this.rbSqrt.Name = "rbSqrt";
            this.rbSqrt.Size = new System.Drawing.Size(14, 13);
            this.rbSqrt.TabIndex = 16;
            this.rbSqrt.TabStop = true;
            this.rbSqrt.UseVisualStyleBackColor = true;
            this.rbSqrt.CheckedChanged += new System.EventHandler(this.rbSqrt_CheckedChanged);
            // 
            // rbSin
            // 
            this.rbSin.AutoSize = true;
            this.rbSin.Location = new System.Drawing.Point(35, 80);
            this.rbSin.Name = "rbSin";
            this.rbSin.Size = new System.Drawing.Size(49, 17);
            this.rbSin.TabIndex = 17;
            this.rbSin.TabStop = true;
            this.rbSin.Text = "sin(x)";
            this.rbSin.UseVisualStyleBackColor = true;
            this.rbSin.CheckedChanged += new System.EventHandler(this.rbSin_CheckedChanged);
            // 
            // rbWOSqrt
            // 
            this.rbWOSqrt.AutoSize = true;
            this.rbWOSqrt.Location = new System.Drawing.Point(35, 130);
            this.rbWOSqrt.Name = "rbWOSqrt";
            this.rbWOSqrt.Size = new System.Drawing.Size(14, 13);
            this.rbWOSqrt.TabIndex = 18;
            this.rbWOSqrt.TabStop = true;
            this.rbWOSqrt.UseVisualStyleBackColor = true;
            this.rbWOSqrt.CheckedChanged += new System.EventHandler(this.rbWOSqrt_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "--------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "(3*x^2+1)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "sqrt(5*x^2+2)";
            // 
            // gbRazb
            // 
            this.gbRazb.Controls.Add(this.rbUniform);
            this.gbRazb.Controls.Add(this.rbCheb);
            this.gbRazb.Location = new System.Drawing.Point(1167, 74);
            this.gbRazb.Name = "gbRazb";
            this.gbRazb.Size = new System.Drawing.Size(112, 116);
            this.gbRazb.TabIndex = 22;
            this.gbRazb.TabStop = false;
            this.gbRazb.Text = "Разбиение";
            // 
            // gbFunc
            // 
            this.gbFunc.Controls.Add(this.label7);
            this.gbFunc.Controls.Add(this.label8);
            this.gbFunc.Controls.Add(this.label10);
            this.gbFunc.Controls.Add(this.label9);
            this.gbFunc.Controls.Add(this.label11);
            this.gbFunc.Controls.Add(this.rbSqrt);
            this.gbFunc.Controls.Add(this.label12);
            this.gbFunc.Controls.Add(this.rbSin);
            this.gbFunc.Controls.Add(this.rbWOSqrt);
            this.gbFunc.Location = new System.Drawing.Point(1296, 66);
            this.gbFunc.Name = "gbFunc";
            this.gbFunc.Size = new System.Drawing.Size(163, 193);
            this.gbFunc.TabIndex = 23;
            this.gbFunc.TabStop = false;
            this.gbFunc.Text = "Функция";
            // 
            // InterpolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 598);
            this.Controls.Add(this.gbFunc);
            this.Controls.Add(this.gbRazb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvError);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chError);
            this.Controls.Add(this.chFunk);
            this.Name = "InterpolForm";
            this.Text = "Interpolation";
            ((System.ComponentModel.ISupportInitialize)(this.chFunk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            this.gbRazb.ResumeLayout(false);
            this.gbRazb.PerformLayout();
            this.gbFunc.ResumeLayout(false);
            this.gbFunc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chFunk;
        private System.Windows.Forms.DataVisualization.Charting.Chart chError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.RadioButton rbUniform;
        private System.Windows.Forms.RadioButton rbCheb;
        private System.Windows.Forms.DataGridView dgvError;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnif;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCheb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbSqrt;
        private System.Windows.Forms.RadioButton rbSin;
        private System.Windows.Forms.RadioButton rbWOSqrt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbRazb;
        private System.Windows.Forms.GroupBox gbFunc;
    }
}

