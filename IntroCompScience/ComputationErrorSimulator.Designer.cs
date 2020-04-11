namespace IntroCompScience
{
    partial class ComputationErrorSimulator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculatePrecision = new System.Windows.Forms.Button();
            this.PowerOfTen = new System.Windows.Forms.TextBox();
            this.FloatingPointNumber = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumberOfSignificantNumbers = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfIterations = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 197);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CalculatePrecision);
            this.groupBox1.Controls.Add(this.PowerOfTen);
            this.groupBox1.Controls.Add(this.FloatingPointNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precision and Magnitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Power of 10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number";
            // 
            // CalculatePrecision
            // 
            this.CalculatePrecision.Location = new System.Drawing.Point(42, 59);
            this.CalculatePrecision.Name = "CalculatePrecision";
            this.CalculatePrecision.Size = new System.Drawing.Size(75, 23);
            this.CalculatePrecision.TabIndex = 8;
            this.CalculatePrecision.Text = "Calculate";
            this.CalculatePrecision.UseVisualStyleBackColor = true;
            this.CalculatePrecision.Click += new System.EventHandler(this.CalculatePrecision_Click_1);
            // 
            // PowerOfTen
            // 
            this.PowerOfTen.Location = new System.Drawing.Point(90, 33);
            this.PowerOfTen.Name = "PowerOfTen";
            this.PowerOfTen.Size = new System.Drawing.Size(71, 20);
            this.PowerOfTen.TabIndex = 7;
            // 
            // FloatingPointNumber
            // 
            this.FloatingPointNumber.Location = new System.Drawing.Point(6, 33);
            this.FloatingPointNumber.Name = "FloatingPointNumber";
            this.FloatingPointNumber.Size = new System.Drawing.Size(78, 20);
            this.FloatingPointNumber.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 345);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(584, 205);
            this.dataGridView2.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NumberOfIterations);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.NumberOfSignificantNumbers);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(209, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 92);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Determine Error";
            // 
            // NumberOfSignificantNumbers
            // 
            this.NumberOfSignificantNumbers.Location = new System.Drawing.Point(6, 33);
            this.NumberOfSignificantNumbers.Name = "NumberOfSignificantNumbers";
            this.NumberOfSignificantNumbers.Size = new System.Drawing.Size(75, 20);
            this.NumberOfSignificantNumbers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "CalculateError";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Significant Digits";
            // 
            // NumberOfIterations
            // 
            this.NumberOfIterations.Location = new System.Drawing.Point(104, 32);
            this.NumberOfIterations.Name = "NumberOfIterations";
            this.NumberOfIterations.Size = new System.Drawing.Size(69, 20);
            this.NumberOfIterations.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No of Iterations";
            // 
            // ComputationErrorSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ComputationErrorSimulator";
            this.Text = "ComputationErrorSimulator";
            this.Load += new System.EventHandler(this.ComputationErrorSimulator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculatePrecision;
        private System.Windows.Forms.TextBox PowerOfTen;
        private System.Windows.Forms.TextBox FloatingPointNumber;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NumberOfSignificantNumbers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberOfIterations;
    }
}