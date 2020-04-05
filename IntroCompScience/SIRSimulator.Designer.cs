namespace IntroCompScience
{
    partial class SIRSimulator
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RunSimulation = new System.Windows.Forms.Button();
            this.SimulationVisualResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SimulationDataResults = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SimulationPeriod = new System.Windows.Forms.TextBox();
            this.TimeIncrement = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SusceptableInitialPopulation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfectedInitialPopulation = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RemovedInitialPopulation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TransmissionRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RecoveryRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "Save Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Save Chart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RunSimulation
            // 
            this.RunSimulation.Location = new System.Drawing.Point(332, 138);
            this.RunSimulation.Name = "RunSimulation";
            this.RunSimulation.Size = new System.Drawing.Size(147, 23);
            this.RunSimulation.TabIndex = 57;
            this.RunSimulation.Text = "Run Simulation";
            this.RunSimulation.UseVisualStyleBackColor = true;
            this.RunSimulation.Click += new System.EventHandler(this.RunSimulation_Click);
            // 
            // SimulationVisualResults
            // 
            chartArea1.Name = "ChartArea1";
            this.SimulationVisualResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SimulationVisualResults.Legends.Add(legend1);
            this.SimulationVisualResults.Location = new System.Drawing.Point(12, 313);
            this.SimulationVisualResults.Name = "SimulationVisualResults";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.SimulationVisualResults.Series.Add(series1);
            this.SimulationVisualResults.Size = new System.Drawing.Size(913, 532);
            this.SimulationVisualResults.TabIndex = 56;
            this.SimulationVisualResults.Text = "chart1";
            // 
            // SimulationDataResults
            // 
            this.SimulationDataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationDataResults.Location = new System.Drawing.Point(12, 167);
            this.SimulationDataResults.Name = "SimulationDataResults";
            this.SimulationDataResults.Size = new System.Drawing.Size(913, 140);
            this.SimulationDataResults.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 64;
            this.label4.Text = "Simulation Period \r\n(Time Span)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Time Increment (DT)";
            // 
            // SimulationPeriod
            // 
            this.SimulationPeriod.Location = new System.Drawing.Point(12, 134);
            this.SimulationPeriod.Name = "SimulationPeriod";
            this.SimulationPeriod.Size = new System.Drawing.Size(91, 20);
            this.SimulationPeriod.TabIndex = 62;
            this.SimulationPeriod.Text = "12";
            // 
            // TimeIncrement
            // 
            this.TimeIncrement.Location = new System.Drawing.Point(12, 73);
            this.TimeIncrement.Name = "TimeIncrement";
            this.TimeIncrement.Size = new System.Drawing.Size(91, 20);
            this.TimeIncrement.TabIndex = 61;
            this.TimeIncrement.Text = "0.001";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SusceptableInitialPopulation);
            this.groupBox1.Location = new System.Drawing.Point(218, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 73);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Susceptable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Initial Population Size";
            // 
            // SusceptableInitialPopulation
            // 
            this.SusceptableInitialPopulation.Location = new System.Drawing.Point(6, 43);
            this.SusceptableInitialPopulation.Name = "SusceptableInitialPopulation";
            this.SusceptableInitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.SusceptableInitialPopulation.TabIndex = 38;
            this.SusceptableInitialPopulation.Text = "250";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.InfectedInitialPopulation);
            this.groupBox2.Location = new System.Drawing.Point(356, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 73);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Initial Population Size";
            // 
            // InfectedInitialPopulation
            // 
            this.InfectedInitialPopulation.Location = new System.Drawing.Point(6, 43);
            this.InfectedInitialPopulation.Name = "InfectedInitialPopulation";
            this.InfectedInitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.InfectedInitialPopulation.TabIndex = 38;
            this.InfectedInitialPopulation.Text = "250";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.RemovedInitialPopulation);
            this.groupBox3.Location = new System.Drawing.Point(494, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 73);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Removed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Initial Population Size";
            // 
            // RemovedInitialPopulation
            // 
            this.RemovedInitialPopulation.Location = new System.Drawing.Point(6, 43);
            this.RemovedInitialPopulation.Name = "RemovedInitialPopulation";
            this.RemovedInitialPopulation.Size = new System.Drawing.Size(100, 20);
            this.RemovedInitialPopulation.TabIndex = 38;
            this.RemovedInitialPopulation.Text = "250";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Transmission Rate";
            // 
            // TransmissionRate
            // 
            this.TransmissionRate.Location = new System.Drawing.Point(123, 75);
            this.TransmissionRate.Name = "TransmissionRate";
            this.TransmissionRate.Size = new System.Drawing.Size(89, 20);
            this.TransmissionRate.TabIndex = 68;
            this.TransmissionRate.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Recovery Rate";
            // 
            // RecoveryRate
            // 
            this.RecoveryRate.Location = new System.Drawing.Point(123, 134);
            this.RecoveryRate.Name = "RecoveryRate";
            this.RecoveryRate.Size = new System.Drawing.Size(89, 20);
            this.RecoveryRate.TabIndex = 70;
            this.RecoveryRate.Text = "12";
            // 
            // SIRSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 857);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RecoveryRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TransmissionRate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SimulationPeriod);
            this.Controls.Add(this.TimeIncrement);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RunSimulation);
            this.Controls.Add(this.SimulationVisualResults);
            this.Controls.Add(this.SimulationDataResults);
            this.Name = "SIRSimulator";
            this.Text = "SIRSimulator";
            ((System.ComponentModel.ISupportInitialize)(this.SimulationVisualResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationDataResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RunSimulation;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimulationVisualResults;
        private System.Windows.Forms.DataGridView SimulationDataResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SimulationPeriod;
        private System.Windows.Forms.TextBox TimeIncrement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SusceptableInitialPopulation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InfectedInitialPopulation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RemovedInitialPopulation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TransmissionRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RecoveryRate;
    }
}