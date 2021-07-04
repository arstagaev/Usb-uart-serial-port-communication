
namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea41 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea42 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea43 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea44 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea45 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pressureChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pressureChart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pressureChart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pressureChart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(870, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 669);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea41.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea41);
            this.chart1.Location = new System.Drawing.Point(594, 87);
            this.chart1.Name = "chart1";
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series41.Name = "Series1";
            this.chart1.Series.Add(series41);
            this.chart1.Size = new System.Drawing.Size(240, 233);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1016, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "no name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Measurments";
            // 
            // pressureChart2
            // 
            chartArea42.Name = "ChartArea1";
            this.pressureChart2.ChartAreas.Add(chartArea42);
            this.pressureChart2.Location = new System.Drawing.Point(40, 49);
            this.pressureChart2.Name = "pressureChart2";
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series42.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series42.LabelForeColor = System.Drawing.Color.DimGray;
            series42.Name = "Series1";
            this.pressureChart2.Series.Add(series42);
            this.pressureChart2.Size = new System.Drawing.Size(523, 160);
            this.pressureChart2.TabIndex = 7;
            this.pressureChart2.Text = "pressureChart2";
            this.pressureChart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // pressureChart3
            // 
            chartArea43.Name = "ChartArea1";
            this.pressureChart3.ChartAreas.Add(chartArea43);
            this.pressureChart3.Location = new System.Drawing.Point(40, 225);
            this.pressureChart3.Name = "pressureChart3";
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series43.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series43.LabelForeColor = System.Drawing.Color.DimGray;
            series43.Name = "Series1";
            this.pressureChart3.Series.Add(series43);
            this.pressureChart3.Size = new System.Drawing.Size(523, 147);
            this.pressureChart3.TabIndex = 8;
            this.pressureChart3.Text = "chart3";
            // 
            // pressureChart4
            // 
            chartArea44.Name = "ChartArea1";
            this.pressureChart4.ChartAreas.Add(chartArea44);
            this.pressureChart4.Location = new System.Drawing.Point(40, 394);
            this.pressureChart4.Name = "pressureChart4";
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series44.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series44.LabelForeColor = System.Drawing.Color.DimGray;
            series44.Name = "Series1";
            this.pressureChart4.Series.Add(series44);
            this.pressureChart4.Size = new System.Drawing.Size(523, 148);
            this.pressureChart4.TabIndex = 9;
            this.pressureChart4.Text = "chart4";
            // 
            // pressureChart5
            // 
            chartArea45.Name = "ChartArea1";
            this.pressureChart5.ChartAreas.Add(chartArea45);
            this.pressureChart5.Location = new System.Drawing.Point(40, 548);
            this.pressureChart5.Name = "pressureChart5";
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series45.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series45.LabelForeColor = System.Drawing.Color.DimGray;
            series45.Name = "Series1";
            this.pressureChart5.Series.Add(series45);
            this.pressureChart5.Size = new System.Drawing.Size(523, 139);
            this.pressureChart5.TabIndex = 10;
            this.pressureChart5.Text = "chart5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Agregatka Technologies v.0.01";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "3";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(870, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "start/pause";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 742);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pressureChart5);
            this.Controls.Add(this.pressureChart4);
            this.Controls.Add(this.pressureChart3);
            this.Controls.Add(this.pressureChart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChart5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressureChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressureChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressureChart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressureChart5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}

