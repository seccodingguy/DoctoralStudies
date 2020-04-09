namespace IntroCompScience
{
    partial class MalariaSimulator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label14 = new System.Windows.Forms.Label();
            this.ProbabilityBit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MalariaInducedDeathRate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.RecoveryRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImmunityRate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MosquitoDeathRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MosquitoBirthFraction = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UninfectedMosquitos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ProbabilityOfBiting = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HumanHosts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UninfectedHumans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Immune = new System.Windows.Forms.TextBox();
            this.RunSimulation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SimulationPeriod = new System.Windows.Forms.TextBox();
            this.TimeIncrement = new System.Windows.Forms.TextBox();
            this.SimulationVisualResultsPopulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SimulationDataResults = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.InitialVectors = new System.Windows.Forms.TextBox();
            this.SimulationVisualResultsProbability = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResultsPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResultsProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(388, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "Probability of Bit";
            // 
            // ProbabilityBit
            // 
            this.ProbabilityBit.Location = new System.Drawing.Point(391, 134);
            this.ProbabilityBit.Name = "ProbabilityBit";
            this.ProbabilityBit.Size = new System.Drawing.Size(75, 20);
            this.ProbabilityBit.TabIndex = 79;
            this.ProbabilityBit.Text = "0.3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 26);
            this.label13.TabIndex = 78;
            this.label13.Text = "Malaria Induced\r\nDeath Rate";
            // 
            // MalariaInducedDeathRate
            // 
            this.MalariaInducedDeathRate.Location = new System.Drawing.Point(302, 134);
            this.MalariaInducedDeathRate.Name = "MalariaInducedDeathRate";
            this.MalariaInducedDeathRate.Size = new System.Drawing.Size(75, 20);
            this.MalariaInducedDeathRate.TabIndex = 77;
            this.MalariaInducedDeathRate.Text = "0.005";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 76;
            this.button2.Text = "Save Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "Save Chart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Recovery Rate";
            // 
            // RecoveryRate
            // 
            this.RecoveryRate.Location = new System.Drawing.Point(217, 134);
            this.RecoveryRate.Name = "RecoveryRate";
            this.RecoveryRate.Size = new System.Drawing.Size(68, 20);
            this.RecoveryRate.TabIndex = 73;
            this.RecoveryRate.Text = "0.3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Immunity Rate";
            // 
            // ImmunityRate
            // 
            this.ImmunityRate.Location = new System.Drawing.Point(140, 134);
            this.ImmunityRate.Name = "ImmunityRate";
            this.ImmunityRate.Size = new System.Drawing.Size(68, 20);
            this.ImmunityRate.TabIndex = 71;
            this.ImmunityRate.Text = "0.01";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MosquitoDeathRate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.MosquitoBirthFraction);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.UninfectedMosquitos);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ProbabilityOfBiting);
            this.groupBox2.Location = new System.Drawing.Point(350, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 69);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mosquito";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Death Rate";
            // 
            // MosquitoDeathRate
            // 
            this.MosquitoDeathRate.Location = new System.Drawing.Point(215, 34);
            this.MosquitoDeathRate.Name = "MosquitoDeathRate";
            this.MosquitoDeathRate.Size = new System.Drawing.Size(62, 20);
            this.MosquitoDeathRate.TabIndex = 46;
            this.MosquitoDeathRate.Text = "0.01";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Birth Rate";
            // 
            // MosquitoBirthFraction
            // 
            this.MosquitoBirthFraction.Location = new System.Drawing.Point(149, 34);
            this.MosquitoBirthFraction.Name = "MosquitoBirthFraction";
            this.MosquitoBirthFraction.Size = new System.Drawing.Size(62, 20);
            this.MosquitoBirthFraction.TabIndex = 43;
            this.MosquitoBirthFraction.Text = "0.01";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Uninfected";
            // 
            // UninfectedMosquitos
            // 
            this.UninfectedMosquitos.Location = new System.Drawing.Point(17, 34);
            this.UninfectedMosquitos.Name = "UninfectedMosquitos";
            this.UninfectedMosquitos.Size = new System.Drawing.Size(62, 20);
            this.UninfectedMosquitos.TabIndex = 40;
            this.UninfectedMosquitos.Text = "300";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Probility Bite";
            // 
            // ProbabilityOfBiting
            // 
            this.ProbabilityOfBiting.Location = new System.Drawing.Point(83, 34);
            this.ProbabilityOfBiting.Name = "ProbabilityOfBiting";
            this.ProbabilityOfBiting.Size = new System.Drawing.Size(62, 20);
            this.ProbabilityOfBiting.TabIndex = 38;
            this.ProbabilityOfBiting.Text = "0.3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.HumanHosts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UninfectedHumans);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Immune);
            this.groupBox1.Location = new System.Drawing.Point(132, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 70);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Human";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Hosts";
            // 
            // HumanHosts
            // 
            this.HumanHosts.Location = new System.Drawing.Point(82, 34);
            this.HumanHosts.Name = "HumanHosts";
            this.HumanHosts.Size = new System.Drawing.Size(53, 20);
            this.HumanHosts.TabIndex = 43;
            this.HumanHosts.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Uninfected";
            // 
            // UninfectedHumans
            // 
            this.UninfectedHumans.Location = new System.Drawing.Point(17, 34);
            this.UninfectedHumans.Name = "UninfectedHumans";
            this.UninfectedHumans.Size = new System.Drawing.Size(59, 20);
            this.UninfectedHumans.TabIndex = 40;
            this.UninfectedHumans.Text = "300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Immune";
            // 
            // Immune
            // 
            this.Immune.Location = new System.Drawing.Point(141, 34);
            this.Immune.Name = "Immune";
            this.Immune.Size = new System.Drawing.Size(59, 20);
            this.Immune.TabIndex = 38;
            this.Immune.Text = "0";
            // 
            // RunSimulation
            // 
            this.RunSimulation.Location = new System.Drawing.Point(486, 7);
            this.RunSimulation.Name = "RunSimulation";
            this.RunSimulation.Size = new System.Drawing.Size(147, 23);
            this.RunSimulation.TabIndex = 67;
            this.RunSimulation.Text = "Run Simulation";
            this.RunSimulation.UseVisualStyleBackColor = true;
            this.RunSimulation.Click += new System.EventHandler(this.RunSimulation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 66;
            this.label4.Text = "Simulation Period \r\n(Time Span)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Time Increment (DT)";
            // 
            // SimulationPeriod
            // 
            this.SimulationPeriod.Location = new System.Drawing.Point(12, 120);
            this.SimulationPeriod.Name = "SimulationPeriod";
            this.SimulationPeriod.Size = new System.Drawing.Size(100, 20);
            this.SimulationPeriod.TabIndex = 64;
            this.SimulationPeriod.Text = "12";
            // 
            // TimeIncrement
            // 
            this.TimeIncrement.Location = new System.Drawing.Point(12, 59);
            this.TimeIncrement.Name = "TimeIncrement";
            this.TimeIncrement.Size = new System.Drawing.Size(100, 20);
            this.TimeIncrement.TabIndex = 63;
            this.TimeIncrement.Text = "0.25";
            // 
            // SimulationVisualResultsPopulation
            // 
            chartArea1.Name = "ChartArea1";
            this.SimulationVisualResultsPopulation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SimulationVisualResultsPopulation.Legends.Add(legend1);
            this.SimulationVisualResultsPopulation.Location = new System.Drawing.Point(12, 510);
            this.SimulationVisualResultsPopulation.Name = "SimulationVisualResultsPopulation";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SimulationVisualResultsPopulation.Series.Add(series1);
            this.SimulationVisualResultsPopulation.Size = new System.Drawing.Size(414, 295);
            this.SimulationVisualResultsPopulation.TabIndex = 62;
            this.SimulationVisualResultsPopulation.Text = "chart1";
            // 
            // SimulationDataResults
            // 
            this.SimulationDataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationDataResults.Location = new System.Drawing.Point(12, 164);
            this.SimulationDataResults.Name = "SimulationDataResults";
            this.SimulationDataResults.Size = new System.Drawing.Size(818, 340);
            this.SimulationDataResults.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Initial Vectors";
            // 
            // InitialVectors
            // 
            this.InitialVectors.Location = new System.Drawing.Point(482, 133);
            this.InitialVectors.Name = "InitialVectors";
            this.InitialVectors.Size = new System.Drawing.Size(75, 20);
            this.InitialVectors.TabIndex = 83;
            this.InitialVectors.Text = "0";
            // 
            // SimulationVisualResultsProbability
            // 
            chartArea2.Name = "ChartArea1";
            this.SimulationVisualResultsProbability.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SimulationVisualResultsProbability.Legends.Add(legend2);
            this.SimulationVisualResultsProbability.Location = new System.Drawing.Point(434, 510);
            this.SimulationVisualResultsProbability.Name = "SimulationVisualResultsProbability";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SimulationVisualResultsProbability.Series.Add(series2);
            this.SimulationVisualResultsProbability.Size = new System.Drawing.Size(396, 295);
            this.SimulationVisualResultsProbability.TabIndex = 85;
            this.SimulationVisualResultsProbability.Text = "chart1";
            // 
            // MalariaSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 817);
            this.Controls.Add(this.SimulationVisualResultsProbability);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InitialVectors);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ProbabilityBit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MalariaInducedDeathRate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RecoveryRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImmunityRate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RunSimulation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SimulationPeriod);
            this.Controls.Add(this.TimeIncrement);
            this.Controls.Add(this.SimulationVisualResultsPopulation);
            this.Controls.Add(this.SimulationDataResults);
            this.Name = "MalariaSimulator";
            this.Text = "MalariaSimulator";
            this.Load += new System.EventHandler(this.MalariaSimulator_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResultsPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResultsProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ProbabilityBit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MalariaInducedDeathRate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RecoveryRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImmunityRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MosquitoDeathRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MosquitoBirthFraction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UninfectedMosquitos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ProbabilityOfBiting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HumanHosts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UninfectedHumans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Immune;
        private System.Windows.Forms.Button RunSimulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SimulationPeriod;
        private System.Windows.Forms.TextBox TimeIncrement;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimulationVisualResultsPopulation;
        private System.Windows.Forms.DataGridView SimulationDataResults;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InitialVectors;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimulationVisualResultsProbability;
    }
}