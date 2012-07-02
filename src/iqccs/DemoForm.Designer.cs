namespace iqccs
{
    partial class DemoForm
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
            this.conditionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.txtVariance = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.buttonGenerateRandom = new System.Windows.Forms.Button();
            this.buttonDisplayRandom = new System.Windows.Forms.Button();
            this.chartingPanel = new System.Windows.Forms.Panel();
            this.plotSurface = new NPlot.Windows.PlotSurface2D();
            this.conditionPanel.SuspendLayout();
            this.chartingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // conditionPanel
            // 
            this.conditionPanel.Controls.Add(this.buttonDisplayRandom);
            this.conditionPanel.Controls.Add(this.buttonGenerateRandom);
            this.conditionPanel.Controls.Add(this.txtCount);
            this.conditionPanel.Controls.Add(this.txtVariance);
            this.conditionPanel.Controls.Add(this.txtMean);
            this.conditionPanel.Controls.Add(this.label3);
            this.conditionPanel.Controls.Add(this.label2);
            this.conditionPanel.Controls.Add(this.label1);
            this.conditionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.conditionPanel.Location = new System.Drawing.Point(0, 0);
            this.conditionPanel.Name = "conditionPanel";
            this.conditionPanel.Size = new System.Drawing.Size(784, 100);
            this.conditionPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "平均数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "标准差:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "个数:";
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(76, 8);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(100, 21);
            this.txtMean.TabIndex = 3;
            // 
            // txtVariance
            // 
            this.txtVariance.Location = new System.Drawing.Point(76, 39);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.Size = new System.Drawing.Size(100, 21);
            this.txtVariance.TabIndex = 4;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(76, 70);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 21);
            this.txtCount.TabIndex = 5;
            // 
            // buttonGenerateRandom
            // 
            this.buttonGenerateRandom.Location = new System.Drawing.Point(204, 23);
            this.buttonGenerateRandom.Name = "buttonGenerateRandom";
            this.buttonGenerateRandom.Size = new System.Drawing.Size(129, 23);
            this.buttonGenerateRandom.TabIndex = 6;
            this.buttonGenerateRandom.Text = "生成随机数";
            this.buttonGenerateRandom.UseVisualStyleBackColor = true;
            this.buttonGenerateRandom.Click += new System.EventHandler(this.buttonGenerateRandom_Click);
            // 
            // buttonDisplayRandom
            // 
            this.buttonDisplayRandom.Location = new System.Drawing.Point(204, 52);
            this.buttonDisplayRandom.Name = "buttonDisplayRandom";
            this.buttonDisplayRandom.Size = new System.Drawing.Size(129, 23);
            this.buttonDisplayRandom.TabIndex = 7;
            this.buttonDisplayRandom.Text = "显示随机数";
            this.buttonDisplayRandom.UseVisualStyleBackColor = true;
            this.buttonDisplayRandom.Click += new System.EventHandler(this.buttonDisplayRandom_Click);
            // 
            // chartingPanel
            // 
            this.chartingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartingPanel.Controls.Add(this.plotSurface);
            this.chartingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartingPanel.Location = new System.Drawing.Point(0, 100);
            this.chartingPanel.Name = "chartingPanel";
            this.chartingPanel.Size = new System.Drawing.Size(784, 462);
            this.chartingPanel.TabIndex = 1;
            // 
            // plotSurface
            // 
            this.plotSurface.AutoScaleAutoGeneratedAxes = false;
            this.plotSurface.AutoScaleTitle = false;
            this.plotSurface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotSurface.DateTimeToolTip = false;
            this.plotSurface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotSurface.Legend = null;
            this.plotSurface.LegendZOrder = -1;
            this.plotSurface.Location = new System.Drawing.Point(0, 0);
            this.plotSurface.Name = "plotSurface";
            this.plotSurface.RightMenu = null;
            this.plotSurface.ShowCoordinates = true;
            this.plotSurface.Size = new System.Drawing.Size(782, 460);
            this.plotSurface.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.plotSurface.TabIndex = 0;
            this.plotSurface.Text = "plotSurface2D1";
            this.plotSurface.Title = "";
            this.plotSurface.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plotSurface.XAxis1 = null;
            this.plotSurface.XAxis2 = null;
            this.plotSurface.YAxis1 = null;
            this.plotSurface.YAxis2 = null;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.chartingPanel);
            this.Controls.Add(this.conditionPanel);
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "室内质量控制计算机模拟";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.conditionPanel.ResumeLayout(false);
            this.conditionPanel.PerformLayout();
            this.chartingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conditionPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtVariance;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.Button buttonDisplayRandom;
        private System.Windows.Forms.Button buttonGenerateRandom;
        private System.Windows.Forms.Panel chartingPanel;
        private NPlot.Windows.PlotSurface2D plotSurface;


    }
}