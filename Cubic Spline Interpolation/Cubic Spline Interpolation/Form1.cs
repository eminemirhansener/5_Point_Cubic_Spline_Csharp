//Emin Emirhan Şener//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Accord.Math;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cubic_Spline_Interpolation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        double[] x_samples = new double[5];
        double[] y_samples = new double[5];

        double[,] k_matrix = new double[3, 3];
        double[] E = new double[3];
        double[] k = new double[5];
        double[] A = new double[4];
        double[] B = new double[4];

        List<double> x_points = new List<double>();
        List<double> y_points = new List<double>();
        public void cubicSpline()
        {

            double[] x_samples = { Convert.ToDouble(x_sample1.Text), Convert.ToDouble(x_sample2.Text),
                                   Convert.ToDouble(x_sample3.Text), Convert.ToDouble(x_sample4.Text),
                                   Convert.ToDouble(x_sample5.Text) };
            double[] y_samples = { Convert.ToDouble(y_sample1.Text), Convert.ToDouble(y_sample2.Text),
                                   Convert.ToDouble(y_sample3.Text), Convert.ToDouble(y_sample4.Text),
                                   Convert.ToDouble(y_sample5.Text) };

            // k_matrix is evaluated to solve the linear equation (ki values)

            k_matrix[0, 0] = 2 * (x_samples[0] - x_samples[2]);
            k_matrix[0, 1] = (x_samples[1] - x_samples[2]);
            k_matrix[0, 2] = 0;

            k_matrix[1, 0] = x_samples[0] - x_samples[1];
            k_matrix[1, 1] = 2 * (x_samples[0] - x_samples[2]);
            k_matrix[1, 2] = (x_samples[1] - x_samples[2]);

            k_matrix[2, 0] = 0;
            k_matrix[2, 1] = (x_samples[0] - x_samples[1]);
            k_matrix[2, 2] = 2 * (x_samples[0] - x_samples[2]);

            // Right side of the equation to solve the linear equation (E)
            for (int i=0 ; i<3 ; i++)
            {
                E[i] = 6 * (((y_samples[i] - y_samples[i + 1]) /
                             (x_samples[i] - x_samples[i + 1])) -
                            ((y_samples[i + 1] - y_samples[i + 2]) /
                             (x_samples[i + 1] - x_samples[i + 2])));
            }

            // Linear equation is solved.
            double[,] inv_k_matrix = k_matrix.Inverse();
            double[] multiplied = Matrix.Dot(inv_k_matrix, E);

            // ki values substituted
            for (int i = 0; i < multiplied.Length; i++)
            {
                k[i+1] = multiplied[i];
            }

            // Ai and Bi values calculated.
            for (int i = 0; i<4; i++)
            {
                A[i] = (y_samples[i] / (x_samples[i] - x_samples[i + 1])) -
                       ((1.0 / 6.0) * k[i] * (x_samples[i] - x_samples[i + 1]));
                B[i] = (y_samples[i + 1] / (x_samples[i] - x_samples[i + 1])) -
                       ((1.0 / 6.0) * k[i + 1] * (x_samples[i] - x_samples[i + 1]));
            }

            // x points defined with 0.1 step.
            double x_count = Convert.ToDouble(x_sample1.Text);
            double x_step = 0.1;
            while (x_count <= Convert.ToDouble(x_sample5.Text))
            {
                x_points.Add(Math.Round(x_count, 1));
                x_count += x_step;
            }

            // y values calculated.
            int count = 0;
            while (Math.Round((x_points[count]), 1) <= Convert.ToDouble(x_sample2.Text))
            {

                y_points.Add((((k[0] * Math.Pow((x_points[count] - x_samples[1]), 3)) -
                               (k[1] * Math.Pow((x_points[count] - x_samples[0]), 3))) /
                               (6.0 * (x_samples[0] - x_samples[1]))) +
                               (A[0] * (x_points[count] - x_samples[1])) -
                               (B[0] * (x_points[count] - x_samples[0])));
                count++;
            }

            // Interpolation is applied to the intervals

            while (Math.Round((x_points[count]), 1) <= Convert.ToDouble(x_sample3.Text))
            {

                y_points.Add((((k[1] * Math.Pow((x_points[count] - x_samples[2]), 3)) -
                               (k[2] * Math.Pow((x_points[count] - x_samples[1]), 3))) /
                               (6.0 * (x_samples[1] - x_samples[2]))) +
                               (A[1] * (x_points[count] - x_samples[2])) -
                               (B[1] * (x_points[count] - x_samples[1])));
                count++;
            }

            while (Math.Round((x_points[count]), 1) <= Convert.ToDouble(x_sample4.Text))
            {

                y_points.Add((((k[2] * Math.Pow((x_points[count] - x_samples[3]), 3)) -
                               (k[3] * Math.Pow((x_points[count] - x_samples[2]), 3))) /
                               (6.0 * (x_samples[2] - x_samples[3]))) +
                               (A[2] * (x_points[count] - x_samples[3])) -
                               (B[2] * (x_points[count] - x_samples[2])));
                count++;
            }

            while (Math.Round((x_points[count]), 1) < Convert.ToDouble(x_sample5.Text))
            {

                y_points.Add((((k[3] * Math.Pow((x_points[count] - x_samples[4]), 3)) -
                               (k[4] * Math.Pow((x_points[count] - x_samples[3]), 3))) /
                               (6.0 * (x_samples[3] - x_samples[4]))) +
                               (A[3] * (x_points[count] - x_samples[4])) -
                               (B[3] * (x_points[count] - x_samples[3])));
                count++;
            }

            y_points.Add((((k[3] * Math.Pow((x_points[count] - x_samples[4]), 3)) -
                           (k[4] * Math.Pow((x_points[count] - x_samples[3]), 3))) /
                           (6.0 * (x_samples[3] - x_samples[4]))) +
                           (A[3] * (x_points[count] - x_samples[4])) -
                           (B[3] * (x_points[count] - x_samples[3])));

        }

        // Data set which will be used in plotting is defined for x and y axis.
        private void plot()
        {
            for(int i = 0; i < (x_points.Count() - 1); i++)
            {
                xyChart.Series["Cubic Spline"].Points.AddXY(x_points[i], y_points[i]);
                xyChart.ChartAreas[0].RecalculateAxesScale();
                //The scale of the graph is optimized(resclaed) for different data sets.
            }
        }

        //Graphic Design
        private void InitChart()
        {

            xyChart.ChartAreas[0].AxisX.Title = "X VALUES";
            xyChart.ChartAreas[0].AxisY.Title = "Y VALUES";
            xyChart.ChartAreas[0].AxisX.Enabled = 
            System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            xyChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            xyChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            xyChart.ChartAreas[0].CursorX.AutoScroll = true;
            xyChart.ChartAreas[0].AxisX.Interval = 10;
            xyChart.ChartAreas[0].AxisY.Interval = 1;
            xyChart.ChartAreas[0].AxisX.IsMarginVisible = false;

            Series series = new Series()
            {
                Name = "Cubic Spline",
                Color = System.Drawing.Color.Black,
                ChartType = SeriesChartType.FastLine,
                IsXValueIndexed = true
            };

            xyChart.Series.Add(series);
            series.BorderWidth = 2;

        }

        //Data set is resetted for next data set.
        private void reset()
        {
            xyChart.Series.Clear();
            x_points.Clear();
            y_points.Clear();
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            reset();
            InitChart();
            cubicSpline();
            plot();
        }

    }
}

//Emin Emirhan Şener//