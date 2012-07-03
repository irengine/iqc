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
using iqccs.rule;

namespace iqccs
{
    public partial class DemoForm : Form
    {
        const float LINE_WIDTH = 1.0f;
        
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

        private void PlotGaussian(double mean, double variance, Color color)
        {
            NormalDist dist = new NormalDist(mean, variance);

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
            lp.Pen = new Pen(color, LINE_WIDTH);
            lp.Label = String.Format("平均数: {0:N}, 标准差: {1:N}", mean, variance);

            plotSurface.Add(lp, PlotSurface2D.XAxisPosition.Bottom, PlotSurface2D.YAxisPosition.Left);
        }

        public void PlotAllGaussian(double mean, double variance)
        {
            plotSurface.Clear();

            PlotGaussian(mean, variance, Color.Green);

            double[] diffMeans = { 0.5, 1.0, 2.0, 3.0, 4.0 };
            double[] diffVariances = { 1.25, 1.50, 1.75, 2.0, 2.5, 3.0 };

            foreach (double diffMean in diffMeans)
                PlotGaussian(mean * (1 + diffMean), variance, Color.Red);

            foreach (double diffVariance in diffVariances)
                PlotGaussian(mean, variance * (diffVariance), Color.Yellow);

            plotSurface.Legend = new Legend();
            plotSurface.YAxis1.WorldMin = 0.0f;
            plotSurface.Title = "正态分布函数";
            plotSurface.Refresh();
        }

        private void PlotPowerFunction(double mean, double variance, string ruleName, bool isMeanOrVariance)
        {
            double[] x, y;

            double[] diffMeans = { 0, 0.5, 1.0, 2.0, 3.0, 4.0 };
            double[] diffVariances = { 1.0, 1.25, 1.50, 1.75, 2.0, 2.5, 3.0 };
            
            if (isMeanOrVariance)
            {
                x = diffMeans;
                y = new double[diffMeans.Length];

                for (int i = 0; i < diffMeans.Length; i++)
                    y[i] = RuleManager.GetValid(ruleName, mean * (1 + x[i]), variance, rnds);
            }
            else
            {
                x = diffVariances;
                y = new double[diffVariances.Length];

                for (int i = 0; i < diffVariances.Length; i++)
                    y[i] = RuleManager.GetValid(ruleName, mean, variance * (x[i]), rnds);
            }

            LinePlot lp = new LinePlot();
            lp.OrdinateData = y;
            lp.AbscissaData = x;
            lp.Pen = new Pen(Color.Blue, LINE_WIDTH);
            lp.Label = ruleName;

            plotSurface.Add(lp, PlotSurface2D.XAxisPosition.Bottom, PlotSurface2D.YAxisPosition.Left);
        }

        public void PlotAllPowerFunction(double mean, double variance, string[] rules, bool isMeanOrVariance)
        {
            plotSurface.Clear();

            foreach(string ruleName in rules)
                PlotPowerFunction(mean, variance, ruleName, isMeanOrVariance);

            plotSurface.Legend = new Legend();
            plotSurface.XAxis1.WorldMin = 0.0f;
            plotSurface.YAxis1.WorldMin = 0.0f;
            plotSurface.Title = "功效函数";
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
                int.TryParse(txtCount.Text, out count) &&
                mean > 0 &&
                variance > 0 &&
                count > 0)
            {
                GenerateRandom(mean, variance, count);
                PlotAllGaussian(mean, variance);
                DisplayRandom();
            }
            else
            {
                MessageBox.Show("请输入正确的平均值、方差和个数!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayRandom()
        {
            RandomListForm randomListForm = new RandomListForm();
            randomListForm.SetData(rnds);
            randomListForm.ShowDialog(this);
        }

        private void buttonGeneratePowerFunction_Click(object sender, EventArgs e)
        {
            bool isMeanOrVariance = ((Button)sender).Name == "buttonGeneratePowerFunctionByMean" ? true : false;
            double mean = 0.0;
            double variance = 1.0;
            int count = 400;

            if (double.TryParse(txtMean.Text, out mean) &&
                double.TryParse(txtVariance.Text, out variance) &&
                int.TryParse(txtCount.Text, out count) &&
                mean > 0 &&
                variance > 0 &&
                count > 0)
            {
                GenerateRandom(mean, variance, count);
                PlotAllPowerFunction(mean, variance, GetRuleList().ToArray<string>(), isMeanOrVariance);
            }
            else
            {
                MessageBox.Show("请输入正确的平均值、方差和个数!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<string> GetRuleList()
        {
            List<string> ruleList = new List<string>();

            foreach (Control ctl in this.conditionPanel.Controls)
            {
                if (ctl is CheckBox && ((CheckBox)ctl).Checked)
                {
                    ruleList.Add(ctl.Text);
                }
            }

            return ruleList;
        }
    }
}
