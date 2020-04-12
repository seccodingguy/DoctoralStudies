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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.XValue = new System.Windows.Forms.TextBox();
            this.YValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoundingError = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.LogicConstant = new System.Windows.Forms.TextBox();
            this.FloatingPointLogic = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CopyToClipboardGrid2 = new System.Windows.Forms.Button();
            this.CopyToClipboardGrid4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 93);
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
            this.dataGridView2.Location = new System.Drawing.Point(12, 209);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(597, 99);
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
            this.groupBox2.Location = new System.Drawing.Point(189, 12);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RoundingError);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.YValue);
            this.groupBox3.Controls.Add(this.XValue);
            this.groupBox3.Location = new System.Drawing.Point(382, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 92);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assignment 3";
            // 
            // XValue
            // 
            this.XValue.Location = new System.Drawing.Point(6, 32);
            this.XValue.Name = "XValue";
            this.XValue.Size = new System.Drawing.Size(48, 20);
            this.XValue.TabIndex = 0;
            // 
            // YValue
            // 
            this.YValue.Location = new System.Drawing.Point(60, 32);
            this.YValue.Name = "YValue";
            this.YValue.Size = new System.Drawing.Size(48, 20);
            this.YValue.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "x-value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "y-value";
            // 
            // RoundingError
            // 
            this.RoundingError.Location = new System.Drawing.Point(23, 60);
            this.RoundingError.Name = "RoundingError";
            this.RoundingError.Size = new System.Drawing.Size(69, 21);
            this.RoundingError.TabIndex = 4;
            this.RoundingError.Text = "Go";
            this.RoundingError.UseVisualStyleBackColor = true;
            this.RoundingError.Click += new System.EventHandler(this.RoundingError_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 314);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(597, 100);
            this.dataGridView3.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.FloatingPointLogic);
            this.groupBox4.Controls.Add(this.LogicConstant);
            this.groupBox4.Location = new System.Drawing.Point(512, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(94, 85);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Assignment 4";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 421);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(597, 201);
            this.dataGridView4.TabIndex = 12;
            // 
            // LogicConstant
            // 
            this.LogicConstant.Location = new System.Drawing.Point(6, 27);
            this.LogicConstant.Name = "LogicConstant";
            this.LogicConstant.Size = new System.Drawing.Size(75, 20);
            this.LogicConstant.TabIndex = 0;
            // 
            // FloatingPointLogic
            // 
            this.FloatingPointLogic.Location = new System.Drawing.Point(18, 56);
            this.FloatingPointLogic.Name = "FloatingPointLogic";
            this.FloatingPointLogic.Size = new System.Drawing.Size(47, 19);
            this.FloatingPointLogic.TabIndex = 1;
            this.FloatingPointLogic.Text = "Go";
            this.FloatingPointLogic.UseVisualStyleBackColor = true;
            this.FloatingPointLogic.Click += new System.EventHandler(this.FloatingPointLogic_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Logic Constant";
            // 
            // CopyToClipboardGrid2
            // 
            this.CopyToClipboardGrid2.Location = new System.Drawing.Point(611, 237);
            this.CopyToClipboardGrid2.Name = "CopyToClipboardGrid2";
            this.CopyToClipboardGrid2.Size = new System.Drawing.Size(75, 23);
            this.CopyToClipboardGrid2.TabIndex = 13;
            this.CopyToClipboardGrid2.Text = "Copy";
            this.CopyToClipboardGrid2.UseVisualStyleBackColor = true;
            this.CopyToClipboardGrid2.Click += new System.EventHandler(this.CopyToClipboardGrid2_Click);
            // 
            // CopyToClipboardGrid4
            // 
            this.CopyToClipboardGrid4.Location = new System.Drawing.Point(611, 512);
            this.CopyToClipboardGrid4.Name = "CopyToClipboardGrid4";
            this.CopyToClipboardGrid4.Size = new System.Drawing.Size(75, 23);
            this.CopyToClipboardGrid4.TabIndex = 14;
            this.CopyToClipboardGrid4.Text = "Copy";
            this.CopyToClipboardGrid4.UseVisualStyleBackColor = true;
            this.CopyToClipboardGrid4.Click += new System.EventHandler(this.CopyToClipboardGrid4_Click);
            // 
            // ComputationErrorSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 634);
            this.Controls.Add(this.CopyToClipboardGrid4);
            this.Controls.Add(this.CopyToClipboardGrid2);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RoundingError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox YValue;
        private System.Windows.Forms.TextBox XValue;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button FloatingPointLogic;
        private System.Windows.Forms.TextBox LogicConstant;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button CopyToClipboardGrid2;
        private System.Windows.Forms.Button CopyToClipboardGrid4;
    }
}