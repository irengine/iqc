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
            this.buttonGeneratePowerFunctionByMean = new System.Windows.Forms.Button();
            this.buttonGenerateRandom = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtVariance = new System.Windows.Forms.TextBox();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartingPanel = new System.Windows.Forms.Panel();
            this.plotSurface = new NPlot.Windows.PlotSurface2D();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.buttonGeneratePowerFunctionByVariance = new System.Windows.Forms.Button();
            this.conditionPanel.SuspendLayout();
            this.chartingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // conditionPanel
            // 
            this.conditionPanel.Controls.Add(this.buttonGeneratePowerFunctionByVariance);
            this.conditionPanel.Controls.Add(this.checkBox13);
            this.conditionPanel.Controls.Add(this.checkBox7);
            this.conditionPanel.Controls.Add(this.checkBox8);
            this.conditionPanel.Controls.Add(this.checkBox9);
            this.conditionPanel.Controls.Add(this.checkBox10);
            this.conditionPanel.Controls.Add(this.checkBox11);
            this.conditionPanel.Controls.Add(this.checkBox12);
            this.conditionPanel.Controls.Add(this.checkBox6);
            this.conditionPanel.Controls.Add(this.checkBox5);
            this.conditionPanel.Controls.Add(this.checkBox4);
            this.conditionPanel.Controls.Add(this.checkBox3);
            this.conditionPanel.Controls.Add(this.checkBox2);
            this.conditionPanel.Controls.Add(this.checkBox1);
            this.conditionPanel.Controls.Add(this.buttonGeneratePowerFunctionByMean);
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
            this.conditionPanel.Size = new System.Drawing.Size(784, 116);
            this.conditionPanel.TabIndex = 0;
            // 
            // buttonGeneratePowerFunctionByMean
            // 
            this.buttonGeneratePowerFunctionByMean.Location = new System.Drawing.Point(481, 71);
            this.buttonGeneratePowerFunctionByMean.Name = "buttonGeneratePowerFunctionByMean";
            this.buttonGeneratePowerFunctionByMean.Size = new System.Drawing.Size(129, 23);
            this.buttonGeneratePowerFunctionByMean.TabIndex = 7;
            this.buttonGeneratePowerFunctionByMean.Text = "生成系统误差功效函数图";
            this.buttonGeneratePowerFunctionByMean.UseVisualStyleBackColor = true;
            this.buttonGeneratePowerFunctionByMean.Click += new System.EventHandler(this.buttonGeneratePowerFunction_Click);
            // 
            // buttonGenerateRandom
            // 
            this.buttonGenerateRandom.Location = new System.Drawing.Point(643, 13);
            this.buttonGenerateRandom.Name = "buttonGenerateRandom";
            this.buttonGenerateRandom.Size = new System.Drawing.Size(129, 23);
            this.buttonGenerateRandom.TabIndex = 6;
            this.buttonGenerateRandom.Text = "生成随机数";
            this.buttonGenerateRandom.UseVisualStyleBackColor = true;
            this.buttonGenerateRandom.Click += new System.EventHandler(this.buttonGenerateRandom_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(428, 15);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 21);
            this.txtCount.TabIndex = 5;
            // 
            // txtVariance
            // 
            this.txtVariance.Location = new System.Drawing.Point(257, 15);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.Size = new System.Drawing.Size(100, 21);
            this.txtVariance.TabIndex = 4;
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(76, 15);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(100, 21);
            this.txtMean.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "个数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "标准差:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "平均数:";
            // 
            // chartingPanel
            // 
            this.chartingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartingPanel.Controls.Add(this.plotSurface);
            this.chartingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartingPanel.Location = new System.Drawing.Point(0, 116);
            this.chartingPanel.Name = "chartingPanel";
            this.chartingPanel.Size = new System.Drawing.Size(784, 446);
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
            this.plotSurface.Size = new System.Drawing.Size(782, 444);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "13S";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(85, 53);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 16);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "12S";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(145, 53);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(42, 16);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "22S";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(205, 53);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(42, 16);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "R4S";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(265, 53);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(42, 16);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "41S";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(325, 53);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(42, 16);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "10X";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(265, 75);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(36, 16);
            this.checkBox7.TabIndex = 19;
            this.checkBox7.Text = "9X";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(205, 75);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(36, 16);
            this.checkBox8.TabIndex = 18;
            this.checkBox8.Text = "6X";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(145, 75);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(42, 16);
            this.checkBox9.TabIndex = 17;
            this.checkBox9.Text = "31S";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(85, 75);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(60, 16);
            this.checkBox10.TabIndex = 16;
            this.checkBox10.Text = "2of32S";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(25, 75);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(42, 16);
            this.checkBox11.TabIndex = 15;
            this.checkBox11.Text = "12X";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(385, 53);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(36, 16);
            this.checkBox12.TabIndex = 14;
            this.checkBox12.Text = "8X";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(325, 75);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(36, 16);
            this.checkBox13.TabIndex = 20;
            this.checkBox13.Text = "7T";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // buttonGeneratePowerFunctionByVariance
            // 
            this.buttonGeneratePowerFunctionByVariance.Location = new System.Drawing.Point(643, 71);
            this.buttonGeneratePowerFunctionByVariance.Name = "buttonGeneratePowerFunctionByVariance";
            this.buttonGeneratePowerFunctionByVariance.Size = new System.Drawing.Size(129, 23);
            this.buttonGeneratePowerFunctionByVariance.TabIndex = 21;
            this.buttonGeneratePowerFunctionByVariance.Text = "生成随机误差功效函数图";
            this.buttonGeneratePowerFunctionByVariance.UseVisualStyleBackColor = true;
            this.buttonGeneratePowerFunctionByVariance.Click += new System.EventHandler(this.buttonGeneratePowerFunction_Click);
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
        private System.Windows.Forms.Button buttonGenerateRandom;
        private System.Windows.Forms.Panel chartingPanel;
        private NPlot.Windows.PlotSurface2D plotSurface;
        private System.Windows.Forms.Button buttonGeneratePowerFunctionByMean;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button buttonGeneratePowerFunctionByVariance;


    }
}