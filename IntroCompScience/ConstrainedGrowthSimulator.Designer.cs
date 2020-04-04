namespace IntroCompScience
{
    partial class ConstrainedGrowthSimulator
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
            this.SimulationDataResults = new System.Windows.Forms.DataGridView();
            this.RunSimulation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SimulationPeriod = new System.Windows.Forms.TextBox();
            this.TimeIncrement = new System.Windows.Forms.TextBox();
            this.InitialPopulation = new System.Windows.Forms.TextBox();
            this.GrowthRate = new System.Windows.Forms.TextBox();
            this.SimulationVisualResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CarryingCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).BeginInit();
            this.SuspendLayout();
            // 
            // SimulationDataResults
            // 
            this.SimulationDataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationDataResults.Location = new System.Drawing.Point(21, 87);
            this.SimulationDataResults.Name = "SimulationDataResults";
            this.SimulationDataResults.Size = new System.Drawing.Size(724, 165);
            this.SimulationDataResults.TabIndex = 22;
            // 
            // RunSimulation
            // 
            this.RunSimulation.Location = new System.Drawing.Point(285, 58);
            this.RunSimulation.Name = "RunSimulation";
            this.RunSimulation.Size = new System.Drawing.Size(147, 23);
            this.RunSimulation.TabIndex = 21;
            this.RunSimulation.Text = "Run Simulation";
            this.RunSimulation.UseVisualStyleBackColor = true;
            this.RunSimulation.Click += new System.EventHandler(this.RunSimulation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Simulation Period (Time Span)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Time Increment (DT)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Initial Population Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Growth Rate";
            // 
            // SimulationPeriod
            // 
            this.SimulationPeriod.Location = new System.Drawing.Point(461, 22);
            this.SimulationPeriod.Name = "SimulationPeriod";
            this.SimulationPeriod.Size = new System.Drawing.Size(100, 20);
            this.SimulationPeriod.TabIndex = 16;
            this.SimulationPeriod.Text = "Simulation Period";
            // 
            // TimeIncrement
            // 
            this.TimeIncrement.Location = new System.Drawing.Point(317, 22);
            this.TimeIncrement.Name = "TimeIncrement";
            this.TimeIncrement.Size = new System.Drawing.Size(100, 20);
            this.TimeIncrement.TabIndex = 15;
            this.TimeIncrement.Text = "Time Increment";
            // 
            // InitialPopulation
            // 
            this.InitialPopulation.Location = new System.Drawing.Point(176, 23);
            this.InitialPopulation.Name = "InitialPopulation";
            this.InitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.InitialPopulation.TabIndex = 14;
            this.InitialPopulation.Text = "Initial Population";
            // 
            // GrowthRate
            // 
            this.GrowthRate.Location = new System.Drawing.Point(35, 23);
            this.GrowthRate.Name = "GrowthRate";
            this.GrowthRate.Size = new System.Drawing.Size(100, 20);
            this.GrowthRate.TabIndex = 13;
            this.GrowthRate.Text = "GrowthRate";
            // 
            // SimulationVisualResults
            // 
            chartArea1.Name = "ChartArea1";
            this.SimulationVisualResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SimulationVisualResults.Legends.Add(legend1);
            this.SimulationVisualResults.Location = new System.Drawing.Point(21, 258);
            this.SimulationVisualResults.Name = "SimulationVisualResults";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SimulationVisualResults.Series.Add(series1);
            this.SimulationVisualResults.Size = new System.Drawing.Size(724, 338);
            this.SimulationVisualResults.TabIndex = 12;
            this.SimulationVisualResults.Text = "chart1";
            // 
            // CarryingCapacity
            // 
            this.CarryingCapacity.Location = new System.Drawing.Point(645, 22);
            this.CarryingCapacity.Name = "CarryingCapacity";
            this.CarryingCapacity.Size = new System.Drawing.Size(100, 20);
            this.CarryingCapacity.TabIndex = 23;
            this.CarryingCapacity.Text = "Carrying Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(645, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Carrying Capacity";
            // 
            // ConstrainedGrowthSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 634);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CarryingCapacity);
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
            this.Name = "ConstrainedGrowthSimulator";
            this.Text = "Constrained Growth Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SimulationDataResults;
        private System.Windows.Forms.Button RunSimulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SimulationPeriod;
        private System.Windows.Forms.TextBox TimeIncrement;
        private System.Windows.Forms.TextBox InitialPopulation;
        private System.Windows.Forms.TextBox GrowthRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimulationVisualResults;
        private System.Windows.Forms.TextBox CarryingCapacity;
        private System.Windows.Forms.Label label5;
    }
}