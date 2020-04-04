namespace IntroCompScience
{
    partial class CompetitionSimulator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SimulationDataResults = new System.Windows.Forms.DataGridView();
            this.RunSimulation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SimulationPeriod = new System.Windows.Forms.TextBox();
            this.TimeIncrement = new System.Windows.Forms.TextBox();
            this.SimulationVisualResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CompetitorOneDeathProportionalityRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CompetitorOneBirthFraction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CompetitorOneCarryingCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompetitorOneInitialPopulation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CompetitorTwoDeathProportionalityRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CompetitorTwoBirthFraction = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CompetitorTwoCarryingCapacity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CompetitorTwoInitialPopulation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SimulationDataResults
            // 
            this.SimulationDataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationDataResults.Location = new System.Drawing.Point(12, 124);
            this.SimulationDataResults.Name = "SimulationDataResults";
            this.SimulationDataResults.Size = new System.Drawing.Size(875, 165);
            this.SimulationDataResults.TabIndex = 35;
            // 
            // RunSimulation
            // 
            this.RunSimulation.Location = new System.Drawing.Point(740, 94);
            this.RunSimulation.Name = "RunSimulation";
            this.RunSimulation.Size = new System.Drawing.Size(147, 23);
            this.RunSimulation.TabIndex = 34;
            this.RunSimulation.Text = "Run Simulation";
            this.RunSimulation.UseVisualStyleBackColor = true;
            this.RunSimulation.Click += new System.EventHandler(this.RunSimulation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Simulation Period (Time Span)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Time Increment (DT)";
            // 
            // SimulationPeriod
            // 
            this.SimulationPeriod.Location = new System.Drawing.Point(13, 80);
            this.SimulationPeriod.Name = "SimulationPeriod";
            this.SimulationPeriod.Size = new System.Drawing.Size(100, 20);
            this.SimulationPeriod.TabIndex = 29;
            this.SimulationPeriod.Text = "Simulation Period";
            // 
            // TimeIncrement
            // 
            this.TimeIncrement.Location = new System.Drawing.Point(15, 21);
            this.TimeIncrement.Name = "TimeIncrement";
            this.TimeIncrement.Size = new System.Drawing.Size(100, 20);
            this.TimeIncrement.TabIndex = 28;
            this.TimeIncrement.Text = "Time Increment";
            // 
            // SimulationVisualResults
            // 
            chartArea2.Name = "ChartArea1";
            this.SimulationVisualResults.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SimulationVisualResults.Legends.Add(legend2);
            this.SimulationVisualResults.Location = new System.Drawing.Point(12, 295);
            this.SimulationVisualResults.Name = "SimulationVisualResults";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SimulationVisualResults.Series.Add(series2);
            this.SimulationVisualResults.Size = new System.Drawing.Size(875, 338);
            this.SimulationVisualResults.TabIndex = 25;
            this.SimulationVisualResults.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CompetitorOneDeathProportionalityRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CompetitorOneBirthFraction);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CompetitorOneCarryingCapacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CompetitorOneInitialPopulation);
            this.groupBox1.Location = new System.Drawing.Point(180, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 111);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Competitor One";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "Death Proportionality \r\nRate";
            // 
            // CompetitorOneDeathProportionalityRate
            // 
            this.CompetitorOneDeathProportionalityRate.Location = new System.Drawing.Point(149, 85);
            this.CompetitorOneDeathProportionalityRate.Name = "CompetitorOneDeathProportionalityRate";
            this.CompetitorOneDeathProportionalityRate.Size = new System.Drawing.Size(95, 20);
            this.CompetitorOneDeathProportionalityRate.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Birth Fraction";
            // 
            // CompetitorOneBirthFraction
            // 
            this.CompetitorOneBirthFraction.Location = new System.Drawing.Point(149, 34);
            this.CompetitorOneBirthFraction.Name = "CompetitorOneBirthFraction";
            this.CompetitorOneBirthFraction.Size = new System.Drawing.Size(99, 20);
            this.CompetitorOneBirthFraction.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Carrying Capacity";
            // 
            // CompetitorOneCarryingCapacity
            // 
            this.CompetitorOneCarryingCapacity.Location = new System.Drawing.Point(17, 34);
            this.CompetitorOneCarryingCapacity.Name = "CompetitorOneCarryingCapacity";
            this.CompetitorOneCarryingCapacity.Size = new System.Drawing.Size(100, 20);
            this.CompetitorOneCarryingCapacity.TabIndex = 40;
            this.CompetitorOneCarryingCapacity.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Initial Population Size";
            // 
            // CompetitorOneInitialPopulation
            // 
            this.CompetitorOneInitialPopulation.Location = new System.Drawing.Point(17, 87);
            this.CompetitorOneInitialPopulation.Name = "CompetitorOneInitialPopulation";
            this.CompetitorOneInitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.CompetitorOneInitialPopulation.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CompetitorTwoDeathProportionalityRate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CompetitorTwoBirthFraction);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CompetitorTwoCarryingCapacity);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CompetitorTwoInitialPopulation);
            this.groupBox2.Location = new System.Drawing.Point(461, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 111);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Competitor Two";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 47;
            this.label8.Text = "Death Proportionality \r\nRate";
            // 
            // CompetitorTwoDeathProportionalityRate
            // 
            this.CompetitorTwoDeathProportionalityRate.Location = new System.Drawing.Point(149, 85);
            this.CompetitorTwoDeathProportionalityRate.Name = "CompetitorTwoDeathProportionalityRate";
            this.CompetitorTwoDeathProportionalityRate.Size = new System.Drawing.Size(95, 20);
            this.CompetitorTwoDeathProportionalityRate.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Birth Fraction";
            // 
            // CompetitorTwoBirthFraction
            // 
            this.CompetitorTwoBirthFraction.Location = new System.Drawing.Point(149, 34);
            this.CompetitorTwoBirthFraction.Name = "CompetitorTwoBirthFraction";
            this.CompetitorTwoBirthFraction.Size = new System.Drawing.Size(99, 20);
            this.CompetitorTwoBirthFraction.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Carrying Capacity";
            // 
            // CompetitorTwoCarryingCapacity
            // 
            this.CompetitorTwoCarryingCapacity.Location = new System.Drawing.Point(17, 34);
            this.CompetitorTwoCarryingCapacity.Name = "CompetitorTwoCarryingCapacity";
            this.CompetitorTwoCarryingCapacity.Size = new System.Drawing.Size(100, 20);
            this.CompetitorTwoCarryingCapacity.TabIndex = 40;
            this.CompetitorTwoCarryingCapacity.Text = "-1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Initial Population Size";
            // 
            // CompetitorTwoInitialPopulation
            // 
            this.CompetitorTwoInitialPopulation.Location = new System.Drawing.Point(17, 87);
            this.CompetitorTwoInitialPopulation.Name = "CompetitorTwoInitialPopulation";
            this.CompetitorTwoInitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.CompetitorTwoInitialPopulation.TabIndex = 38;
            // 
            // CompetitionSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SimulationDataResults);
            this.Controls.Add(this.RunSimulation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SimulationPeriod);
            this.Controls.Add(this.TimeIncrement);
            this.Controls.Add(this.SimulationVisualResults);
            this.Name = "CompetitionSimulator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SimulationDataResults;
        private System.Windows.Forms.Button RunSimulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SimulationPeriod;
        private System.Windows.Forms.TextBox TimeIncrement;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimulationVisualResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CompetitorOneDeathProportionalityRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CompetitorOneBirthFraction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CompetitorOneCarryingCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CompetitorOneInitialPopulation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CompetitorTwoDeathProportionalityRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CompetitorTwoBirthFraction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CompetitorTwoCarryingCapacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CompetitorTwoInitialPopulation;
    }
}