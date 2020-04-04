namespace IntroCompScience
{
    partial class UnconstrainedGrowthSimulator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnconstrainedGrowthSimulator));
            this.SimulationVisualResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GrowthRate = new System.Windows.Forms.TextBox();
            this.InitialPopulation = new System.Windows.Forms.TextBox();
            this.TimeIncrement = new System.Windows.Forms.TextBox();
            this.SimulationPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RunSimulation = new System.Windows.Forms.Button();
            this.SimulationDataResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).BeginInit();
            this.SuspendLayout();
            // 
            // SimulationVisualResults
            // 
            chartArea1.Name = "ChartArea1";
            this.SimulationVisualResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SimulationVisualResults.Legends.Add(legend1);
            this.SimulationVisualResults.Location = new System.Drawing.Point(37, 267);
            this.SimulationVisualResults.Name = "SimulationVisualResults";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SimulationVisualResults.Series.Add(series1);
            this.SimulationVisualResults.Size = new System.Drawing.Size(724, 338);
            this.SimulationVisualResults.TabIndex = 0;
            this.SimulationVisualResults.Text = "chart1";
            // 
            // GrowthRate
            // 
            this.GrowthRate.Location = new System.Drawing.Point(51, 32);
            this.GrowthRate.Name = "GrowthRate";
            this.GrowthRate.Size = new System.Drawing.Size(100, 20);
            this.GrowthRate.TabIndex = 1;
            this.GrowthRate.Text = "GrowthRate";
            // 
            // InitialPopulation
            // 
            this.InitialPopulation.Location = new System.Drawing.Point(192, 32);
            this.InitialPopulation.Name = "InitialPopulation";
            this.InitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.InitialPopulation.TabIndex = 2;
            this.InitialPopulation.Text = "Initial Population";
            // 
            // TimeIncrement
            // 
            this.TimeIncrement.Location = new System.Drawing.Point(333, 31);
            this.TimeIncrement.Name = "TimeIncrement";
            this.TimeIncrement.Size = new System.Drawing.Size(100, 20);
            this.TimeIncrement.TabIndex = 3;
            this.TimeIncrement.Text = "Time Increment";
            // 
            // SimulationPeriod
            // 
            this.SimulationPeriod.Location = new System.Drawing.Point(477, 31);
            this.SimulationPeriod.Name = "SimulationPeriod";
            this.SimulationPeriod.Size = new System.Drawing.Size(100, 20);
            this.SimulationPeriod.TabIndex = 4;
            this.SimulationPeriod.Text = "Simulation Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Growth Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Initial Population Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time Increment (DT)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Simulation Period (Time Span)";
            // 
            // RunSimulation
            // 
            this.RunSimulation.Location = new System.Drawing.Point(301, 67);
            this.RunSimulation.Name = "RunSimulation";
            this.RunSimulation.Size = new System.Drawing.Size(147, 23);
            this.RunSimulation.TabIndex = 10;
            this.RunSimulation.Text = "Run Simulation";
            this.RunSimulation.UseVisualStyleBackColor = true;
            this.RunSimulation.Click += new System.EventHandler(this.RunSimulation_Click);
            // 
            // SimulationDataResults
            // 
            this.SimulationDataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationDataResults.Location = new System.Drawing.Point(37, 96);
            this.SimulationDataResults.Name = "SimulationDataResults";
            this.SimulationDataResults.Size = new System.Drawing.Size(724, 165);
            this.SimulationDataResults.TabIndex = 11;
            // 
            // UnconstrainedGrowthSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.SimulationDataResults);
            this.Controls.Add(this.RunSimulation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimulationPeriod);
            this.Controls.Add(this.TimeIncrement);
            this.Controls.Add(this.InitialPopulation);
            this.Controls.Add(this.GrowthRate);
            this.Controls.Add(this.SimulationVisualResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnconstrainedGrowthSimulator";
            this.Text = "Unconstrained Growth Simulation Model";
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SimulationVisualResults;
        private System.Windows.Forms.TextBox GrowthRate;
        private System.Windows.Forms.TextBox InitialPopulation;
        private System.Windows.Forms.TextBox TimeIncrement;
        private System.Windows.Forms.TextBox SimulationPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RunSimulation;
        private System.Windows.Forms.DataGridView SimulationDataResults;
    }
}

