namespace LabSimmod1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.NumericUpDown();
            this.AngleInput = new System.Windows.Forms.NumericUpDown();
            this.SpeedInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WeightInput = new System.Windows.Forms.NumericUpDown();
            this.SizeInput = new System.Windows.Forms.NumericUpDown();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Result = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.errlabel = new System.Windows.Forms.Label();
            this.Timestep = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeInput)).BeginInit();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timestep)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.Enabled = false;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(16, 242);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series37.BorderWidth = 2;
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series37.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series37.Legend = "Legend1";
            series37.Name = "Series1";
            series38.BorderWidth = 2;
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series38.Color = System.Drawing.Color.Blue;
            series38.Legend = "Legend1";
            series38.Name = "Series2";
            series39.BorderWidth = 2;
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series39.Color = System.Drawing.Color.Teal;
            series39.Legend = "Legend1";
            series39.Name = "Series3";
            series40.BorderWidth = 2;
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series40.Color = System.Drawing.Color.Fuchsia;
            series40.Legend = "Legend1";
            series40.Name = "Series4";
            series41.BorderWidth = 2;
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series41.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series41.Legend = "Legend1";
            series41.Name = "Series5";
            series42.BorderWidth = 2;
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series42.Color = System.Drawing.Color.Red;
            series42.Legend = "Legend1";
            series42.Name = "Series6";
            this.chart1.Series.Add(series37);
            this.chart1.Series.Add(series38);
            this.chart1.Series.Add(series39);
            this.chart1.Series.Add(series40);
            this.chart1.Series.Add(series41);
            this.chart1.Series.Add(series42);
            this.chart1.Size = new System.Drawing.Size(1200, 369);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Speed:";
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(120, 18);
            this.HeightInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(160, 22);
            this.HeightInput.TabIndex = 7;
            // 
            // AngleInput
            // 
            this.AngleInput.Location = new System.Drawing.Point(120, 50);
            this.AngleInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AngleInput.Name = "AngleInput";
            this.AngleInput.Size = new System.Drawing.Size(160, 22);
            this.AngleInput.TabIndex = 8;
            this.AngleInput.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // SpeedInput
            // 
            this.SpeedInput.Location = new System.Drawing.Point(120, 82);
            this.SpeedInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpeedInput.Name = "SpeedInput";
            this.SpeedInput.Size = new System.Drawing.Size(160, 22);
            this.SpeedInput.TabIndex = 9;
            this.SpeedInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Weight:";
            // 
            // WeightInput
            // 
            this.WeightInput.Location = new System.Drawing.Point(120, 146);
            this.WeightInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeightInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(160, 22);
            this.WeightInput.TabIndex = 12;
            this.WeightInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SizeInput
            // 
            this.SizeInput.Location = new System.Drawing.Point(120, 114);
            this.SizeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeInput.Name = "SizeInput";
            this.SizeInput.Size = new System.Drawing.Size(160, 22);
            this.SizeInput.TabIndex = 13;
            this.SizeInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(97, 209);
            this.LaunchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(160, 28);
            this.LaunchButton.TabIndex = 14;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.ColumnCount = 7;
            this.Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.Result.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.Result.Controls.Add(this.label6, 0, 0);
            this.Result.Controls.Add(this.label9, 0, 3);
            this.Result.Controls.Add(this.label8, 0, 2);
            this.Result.Controls.Add(this.label7, 0, 1);
            this.Result.Location = new System.Drawing.Point(288, 20);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Result.Name = "Result";
            this.Result.Padding = new System.Windows.Forms.Padding(1);
            this.Result.RowCount = 4;
            this.Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Result.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Result.Size = new System.Drawing.Size(933, 181);
            this.Result.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Time step";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "End point speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Max Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Distance";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(265, 209);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(160, 28);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // errlabel
            // 
            this.errlabel.AutoSize = true;
            this.errlabel.ForeColor = System.Drawing.Color.Red;
            this.errlabel.Location = new System.Drawing.Point(455, 213);
            this.errlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errlabel.Name = "errlabel";
            this.errlabel.Size = new System.Drawing.Size(0, 16);
            this.errlabel.TabIndex = 17;
            // 
            // Timestep
            // 
            this.Timestep.Location = new System.Drawing.Point(120, 178);
            this.Timestep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Timestep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            720896});
            this.Timestep.Name = "Timestep";
            this.Timestep.Size = new System.Drawing.Size(160, 22);
            this.Timestep.TabIndex = 18;
            this.Timestep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Timestep.ValueChanged += new System.EventHandler(this.Timestep_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Time step*0,01:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 626);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Timestep);
            this.Controls.Add(this.errlabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.SizeInput);
            this.Controls.Add(this.WeightInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpeedInput);
            this.Controls.Add(this.AngleInput);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeInput)).EndInit();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timestep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown HeightInput;
        private System.Windows.Forms.NumericUpDown AngleInput;
        private System.Windows.Forms.NumericUpDown SpeedInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown WeightInput;
        private System.Windows.Forms.NumericUpDown SizeInput;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label errlabel;
        private System.Windows.Forms.NumericUpDown Timestep;
        private System.Windows.Forms.Label label10;
    }
}

