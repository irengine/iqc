using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPlot;
using iqccs.algorithm;

namespace iqccs
{
    public partial class DemoForm : Form
    {
        private double[] rnds = new double[0];

        private void GenerateRandom(double mean, double variance, int count)
        {
            rnds = new double[count];

            for (int i = 0; i < count; i++)
            {
                rnds[i] = SimpleRNG.GetNormal(mean, variance);
            }
        }

        #region PlotGaussian
        public void PlotGaussian(double mean, double variance)
        {
            NormalDist dist = new NormalDist( mean, variance );

            plotSurface.Clear();

            int count = Convert.ToInt32((10 * variance) / 0.1) + 1;
            double[] x = new double[count];
            double[] y = new double[count];

            int idx = 0;
            for (double i = -5 * variance; i <= 5 * variance; i = i + 0.1)
            {
                x[idx] = mean + i;
                y[idx] = dist.PDF(mean + i);
                idx++;
            }

            LinePlot lp = new LinePlot();
            lp.OrdinateData = y;
            lp.AbscissaData = x;
            lp.Pen = new Pen(Color.Blue, 3.0f);
            lp.Label = "正态分布函数";

            plotSurface.Add(lp, PlotSurface2D.XAxisPosition.Bottom, PlotSurface2D.YAxisPosition.Left);
            plotSurface.Legend = new Legend();
            plotSurface.YAxis1.WorldMin = 0.0f;
            plotSurface.Title = "图例";
            plotSurface.Refresh();
        }
        #endregion



        public DemoForm()
        {
            InitializeComponent();
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenerateRandom_Click(object sender, EventArgs e)
        {
            double mean = 0.0;
            double variance = 1.0;
            int count = 400;

            if (double.TryParse(txtMean.Text, out mean) &&
                double.TryParse(txtVariance.Text, out variance) &&
                int.TryParse(txtCount.Text, out count))
            {
                GenerateRandom(mean, variance, count);
                PlotGaussian(mean, variance);
            }
            else
            {
                MessageBox.Show("请输入正确的平均值、方差和个数!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDisplayRandom_Click(object sender, EventArgs e)
        {
            RandomListForm randomListForm = new RandomListForm();
            randomListForm.SetData(rnds);
            randomListForm.ShowDialog(this);
        }
    }
}
