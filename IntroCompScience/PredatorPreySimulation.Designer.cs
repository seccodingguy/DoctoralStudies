namespace IntroCompScience
{
    partial class PredatorPreySimulation
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
            this.label8 = new System.Windows.Forms.Label();
            this.PredatorDeathProportionalityRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PredatorBirthFraction = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PredatorCarryingCapacity = new System.Windows.Forms.TextBox();
            this.PredatorInitialPopulation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PreyDeathProportionalityRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PreyBirthFraction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PreyCarryingCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PreyInitialPopulation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RunSimulation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SimulationPeriod = new System.Windows.Forms.TextBox();
            this.TimeIncrement = new System.Windows.Forms.TextBox();
            this.SimulationVisualResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SimulationDataResults = new System.Windows.Forms.DataGridView();
            this.PreyGrowthRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PredatorGrowthRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AlphaNP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AlphaPN = new System.Windows.Forms.TextBox();
            this.PreyOnly = new System.Windows.Forms.CheckBox();
            this.PredatorOnly = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 47;
            this.label8.Text = "Death Proportionality\r\nRate";
            // 
            // PredatorDeathProportionalityRate
            // 
            this.PredatorDeathProportionalityRate.Location = new System.Drawing.Point(149, 85);
            this.PredatorDeathProportionalityRate.Name = "PredatorDeathProportionalityRate";
            this.PredatorDeathProportionalityRate.Size = new System.Drawing.Size(95, 20);
            this.PredatorDeathProportionalityRate.TabIndex = 46;
            this.PredatorDeathProportionalityRate.Text = "1.0255";
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
            // PredatorBirthFraction
            // 
            this.PredatorBirthFraction.Location = new System.Drawing.Point(149, 34);
            this.PredatorBirthFraction.Name = "PredatorBirthFraction";
            this.PredatorBirthFraction.Size = new System.Drawing.Size(99, 20);
            this.PredatorBirthFraction.TabIndex = 43;
            this.PredatorBirthFraction.Text = "0.01";
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
            // PredatorCarryingCapacity
            // 
            this.PredatorCarryingCapacity.Location = new System.Drawing.Point(17, 34);
            this.PredatorCarryingCapacity.Name = "PredatorCarryingCapacity";
            this.PredatorCarryingCapacity.Size = new System.Drawing.Size(100, 20);
            this.PredatorCarryingCapacity.TabIndex = 40;
            this.PredatorCarryingCapacity.Text = "50";
            // 
            // PredatorInitialPopulation
            // 
            this.PredatorInitialPopulation.Location = new System.Drawing.Point(17, 87);
            this.PredatorInitialPopulation.Name = "PredatorInitialPopulation";
            this.PredatorInitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.PredatorInitialPopulation.TabIndex = 38;
            this.PredatorInitialPopulation.Text = "50";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.PredatorDeathProportionalityRate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.PredatorBirthFraction);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.PredatorCarryingCapacity);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.PredatorInitialPopulation);
            this.groupBox2.Location = new System.Drawing.Point(401, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 111);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Predator";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "Death Proportionality \r\nRate";
            // 
            // PreyDeathProportionalityRate
            // 
            this.PreyDeathProportionalityRate.Location = new System.Drawing.Point(149, 85);
            this.PreyDeathProportionalityRate.Name = "PreyDeathProportionalityRate";
            this.PreyDeathProportionalityRate.Size = new System.Drawing.Size(95, 20);
            this.PreyDeathProportionalityRate.TabIndex = 46;
            this.PreyDeathProportionalityRate.Text = "0.02";
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
            // PreyBirthFraction
            // 
            this.PreyBirthFraction.Location = new System.Drawing.Point(149, 34);
            this.PreyBirthFraction.Name = "PreyBirthFraction";
            this.PreyBirthFraction.Size = new System.Drawing.Size(99, 20);
            this.PreyBirthFraction.TabIndex = 43;
            this.PreyBirthFraction.Text = "0.0205";
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
            // PreyCarryingCapacity
            // 
            this.PreyCarryingCapacity.Location = new System.Drawing.Point(17, 34);
            this.PreyCarryingCapacity.Name = "PreyCarryingCapacity";
            this.PreyCarryingCapacity.Size = new System.Drawing.Size(100, 20);
            this.PreyCarryingCapacity.TabIndex = 40;
            this.PreyCarryingCapacity.Text = "250";
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
            // PreyInitialPopulation
            // 
            this.PreyInitialPopulation.Location = new System.Drawing.Point(17, 87);
            this.PreyInitialPopulation.Name = "PreyInitialPopulation";
            this.PreyInitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.PreyInitialPopulation.TabIndex = 38;
            this.PreyInitialPopulation.Text = "250";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PreyDeathProportionalityRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PreyBirthFraction);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PreyCarryingCapacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PreyInitialPopulation);
            this.groupBox1.Location = new System.Drawing.Point(132, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 111);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prey";
            // 
            // RunSimulation
            // 
            this.RunSimulation.Location = new System.Drawing.Point(717, 128);
            this.RunSimulation.Name = "RunSimulation";
            this.RunSimulation.Size = new System.Drawing.Size(147, 23);
            this.RunSimulation.TabIndex = 45;
            this.RunSimulation.Text = "Run Simulation";
            this.RunSimulation.UseVisualStyleBackColor = true;
            this.RunSimulation.Click += new System.EventHandler(this.RunSimulation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "Simulation Period \r\n(Time Span)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Time Increment (DT)";
            // 
            // SimulationPeriod
            // 
            this.SimulationPeriod.Location = new System.Drawing.Point(12, 114);
            this.SimulationPeriod.Name = "SimulationPeriod";
            this.SimulationPeriod.Size = new System.Drawing.Size(100, 20);
            this.SimulationPeriod.TabIndex = 42;
            this.SimulationPeriod.Text = "12";
            // 
            // TimeIncrement
            // 
            this.TimeIncrement.Location = new System.Drawing.Point(12, 53);
            this.TimeIncrement.Name = "TimeIncrement";
            this.TimeIncrement.Size = new System.Drawing.Size(100, 20);
            this.TimeIncrement.TabIndex = 41;
            this.TimeIncrement.Text = "0.001";
            // 
            // SimulationVisualResults
            // 
            chartArea2.Name = "ChartArea1";
            this.SimulationVisualResults.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SimulationVisualResults.Legends.Add(legend2);
            this.SimulationVisualResults.Location = new System.Drawing.Point(12, 304);
            this.SimulationVisualResults.Name = "SimulationVisualResults";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SimulationVisualResults.Series.Add(series2);
            this.SimulationVisualResults.Size = new System.Drawing.Size(875, 338);
            this.SimulationVisualResults.TabIndex = 40;
            this.SimulationVisualResults.Text = "chart1";
            // 
            // SimulationDataResults
            // 
            this.SimulationDataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationDataResults.Location = new System.Drawing.Point(12, 158);
            this.SimulationDataResults.Name = "SimulationDataResults";
            this.SimulationDataResults.Size = new System.Drawing.Size(875, 140);
            this.SimulationDataResults.TabIndex = 46;
            // 
            // PreyGrowthRate
            // 
            this.PreyGrowthRate.Location = new System.Drawing.Point(680, 49);
            this.PreyGrowthRate.Name = "PreyGrowthRate";
            this.PreyGrowthRate.Size = new System.Drawing.Size(68, 20);
            this.PreyGrowthRate.TabIndex = 50;
            this.PreyGrowthRate.Text = "0.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "Prey Growth \r\nRate";
            // 
            // PredatorGrowthRate
            // 
            this.PredatorGrowthRate.Location = new System.Drawing.Point(680, 102);
            this.PredatorGrowthRate.Name = "PredatorGrowthRate";
            this.PredatorGrowthRate.Size = new System.Drawing.Size(68, 20);
            this.PredatorGrowthRate.TabIndex = 52;
            this.PredatorGrowthRate.Text = "0.5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(679, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 26);
            this.label12.TabIndex = 53;
            this.label12.Text = "Predator Growth \r\nRate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Save Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "Save Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AlphaNP
            // 
            this.AlphaNP.Location = new System.Drawing.Point(789, 50);
            this.AlphaNP.Name = "AlphaNP";
            this.AlphaNP.Size = new System.Drawing.Size(75, 20);
            this.AlphaNP.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(786, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "AlphaNP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(786, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "AlphaPN";
            // 
            // AlphaPN
            // 
            this.AlphaPN.Location = new System.Drawing.Point(789, 102);
            this.AlphaPN.Name = "AlphaPN";
            this.AlphaPN.Size = new System.Drawing.Size(75, 20);
            this.AlphaPN.TabIndex = 58;
            // 
            // PreyOnly
            // 
            this.PreyOnly.AutoSize = true;
            this.PreyOnly.Location = new System.Drawing.Point(426, 7);
            this.PreyOnly.Name = "PreyOnly";
            this.PreyOnly.Size = new System.Drawing.Size(109, 17);
            this.PreyOnly.TabIndex = 60;
            this.PreyOnly.Text = "Run for Prey Only";
            this.PreyOnly.UseVisualStyleBackColor = true;
            this.PreyOnly.CheckedChanged += new System.EventHandler(this.PreyOnly_CheckedChanged);
            // 
            // PredatorOnly
            // 
            this.PredatorOnly.AutoSize = true;
            this.PredatorOnly.Location = new System.Drawing.Point(550, 7);
            this.PredatorOnly.Name = "PredatorOnly";
            this.PredatorOnly.Size = new System.Drawing.Size(128, 17);
            this.PredatorOnly.TabIndex = 61;
            this.PredatorOnly.Text = "Run for Predator Only";
            this.PredatorOnly.UseVisualStyleBackColor = true;
            this.PredatorOnly.CheckedChanged += new System.EventHandler(this.PredatorOnly_CheckedChanged);
            // 
            // PredatorPreySimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 652);
            this.Controls.Add(this.PredatorOnly);
            this.Controls.Add(this.PreyOnly);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AlphaPN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AlphaNP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PredatorGrowthRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreyGrowthRate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RunSimulation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SimulationPeriod);
            this.Controls.Add(this.TimeIncrement);
            this.Controls.Add(this.SimulationVisualResults);
            this.Controls.Add(this.SimulationDataResults);
            this.Name = "PredatorPreySimulation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PredatorPreySimulation_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PredatorDeathProportionalityRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PredatorBirthFraction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PredatorCarryingCapacity;
        private System.Windows.Forms.TextBox PredatorInitialPopulation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PreyDeathProportionalityRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PreyBirthFraction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PreyCarryingCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreyInitialPopulation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RunSimulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SimulationPeriod;
        private System.Windows.Forms.TextBox TimeIncrement;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimulationVisualResults;
        private System.Windows.Forms.DataGridView SimulationDataResults;
        private System.Windows.Forms.TextBox PreyGrowthRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PredatorGrowthRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox AlphaNP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AlphaPN;
        private System.Windows.Forms.CheckBox PreyOnly;
        private System.Windows.Forms.CheckBox PredatorOnly;
    }
}