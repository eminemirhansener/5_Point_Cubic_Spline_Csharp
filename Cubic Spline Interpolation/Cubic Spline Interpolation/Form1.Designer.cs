namespace Cubic_Spline_Interpolation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.x_sample1 = new System.Windows.Forms.TextBox();
            this.x_sample2 = new System.Windows.Forms.TextBox();
            this.x_sample3 = new System.Windows.Forms.TextBox();
            this.x_sample4 = new System.Windows.Forms.TextBox();
            this.x_sample5 = new System.Windows.Forms.TextBox();
            this.y_sample5 = new System.Windows.Forms.TextBox();
            this.y_sample4 = new System.Windows.Forms.TextBox();
            this.y_sample3 = new System.Windows.Forms.TextBox();
            this.y_sample2 = new System.Windows.Forms.TextBox();
            this.y_sample1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.execute_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // x_sample1
            // 
            this.x_sample1.Location = new System.Drawing.Point(540, 25);
            this.x_sample1.Name = "x_sample1";
            this.x_sample1.Size = new System.Drawing.Size(52, 20);
            this.x_sample1.TabIndex = 1;
            // 
            // x_sample2
            // 
            this.x_sample2.Location = new System.Drawing.Point(540, 51);
            this.x_sample2.Name = "x_sample2";
            this.x_sample2.Size = new System.Drawing.Size(52, 20);
            this.x_sample2.TabIndex = 2;
            // 
            // x_sample3
            // 
            this.x_sample3.Location = new System.Drawing.Point(540, 77);
            this.x_sample3.Name = "x_sample3";
            this.x_sample3.Size = new System.Drawing.Size(52, 20);
            this.x_sample3.TabIndex = 3;
            // 
            // x_sample4
            // 
            this.x_sample4.Location = new System.Drawing.Point(540, 103);
            this.x_sample4.Name = "x_sample4";
            this.x_sample4.Size = new System.Drawing.Size(52, 20);
            this.x_sample4.TabIndex = 4;
            // 
            // x_sample5
            // 
            this.x_sample5.Location = new System.Drawing.Point(540, 129);
            this.x_sample5.Name = "x_sample5";
            this.x_sample5.Size = new System.Drawing.Size(52, 20);
            this.x_sample5.TabIndex = 5;
            // 
            // y_sample5
            // 
            this.y_sample5.Location = new System.Drawing.Point(616, 129);
            this.y_sample5.Name = "y_sample5";
            this.y_sample5.Size = new System.Drawing.Size(52, 20);
            this.y_sample5.TabIndex = 10;
            // 
            // y_sample4
            // 
            this.y_sample4.Location = new System.Drawing.Point(616, 103);
            this.y_sample4.Name = "y_sample4";
            this.y_sample4.Size = new System.Drawing.Size(52, 20);
            this.y_sample4.TabIndex = 9;
            // 
            // y_sample3
            // 
            this.y_sample3.Location = new System.Drawing.Point(616, 77);
            this.y_sample3.Name = "y_sample3";
            this.y_sample3.Size = new System.Drawing.Size(52, 20);
            this.y_sample3.TabIndex = 8;
            // 
            // y_sample2
            // 
            this.y_sample2.Location = new System.Drawing.Point(616, 51);
            this.y_sample2.Name = "y_sample2";
            this.y_sample2.Size = new System.Drawing.Size(52, 20);
            this.y_sample2.TabIndex = 7;
            // 
            // y_sample1
            // 
            this.y_sample1.Location = new System.Drawing.Point(616, 25);
            this.y_sample1.Name = "y_sample1";
            this.y_sample1.Size = new System.Drawing.Size(52, 20);
            this.y_sample1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "x Samples";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "y Samples";
            // 
            // xyChart
            // 
            chartArea3.Name = "ChartArea1";
            this.xyChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.xyChart.Legends.Add(legend3);
            this.xyChart.Location = new System.Drawing.Point(12, 9);
            this.xyChart.Name = "xyChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.xyChart.Series.Add(series3);
            this.xyChart.Size = new System.Drawing.Size(447, 349);
            this.xyChart.TabIndex = 17;
            this.xyChart.Text = "chart1";
            // 
            // execute_button
            // 
            this.execute_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute_button.Location = new System.Drawing.Point(602, 315);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(96, 43);
            this.execute_button.TabIndex = 18;
            this.execute_button.Text = "Execute";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(521, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(521, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 370);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.execute_button);
            this.Controls.Add(this.xyChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y_sample5);
            this.Controls.Add(this.y_sample4);
            this.Controls.Add(this.y_sample3);
            this.Controls.Add(this.y_sample2);
            this.Controls.Add(this.y_sample1);
            this.Controls.Add(this.x_sample5);
            this.Controls.Add(this.x_sample4);
            this.Controls.Add(this.x_sample3);
            this.Controls.Add(this.x_sample2);
            this.Controls.Add(this.x_sample1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Cubic Spline Interpolation";
            ((System.ComponentModel.ISupportInitialize)(this.xyChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox x_sample2;
        private System.Windows.Forms.TextBox x_sample3;
        private System.Windows.Forms.TextBox x_sample4;
        private System.Windows.Forms.TextBox x_sample5;
        private System.Windows.Forms.TextBox y_sample5;
        private System.Windows.Forms.TextBox y_sample4;
        private System.Windows.Forms.TextBox y_sample3;
        private System.Windows.Forms.TextBox y_sample2;
        private System.Windows.Forms.TextBox y_sample1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x_sample1;
        private System.Windows.Forms.DataVisualization.Charting.Chart xyChart;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

