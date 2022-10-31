namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNumberOfElements = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbDesiredValue = new System.Windows.Forms.TextBox();
            this.dgvFinalCoefficients = new System.Windows.Forms.DataGridView();
            this.dgvInitialCoefficients = new System.Windows.Forms.DataGridView();
            this.dgvInputSignals = new System.Windows.Forms.DataGridView();
            this.labelNumberOfIterations = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TextBox();
            this.randomCoeff = new System.Windows.Forms.Button();
            this.startWithRandom = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalCoefficients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialCoefficients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputSignals)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumberOfElements
            // 
            this.tbNumberOfElements.Location = new System.Drawing.Point(251, 543);
            this.tbNumberOfElements.Name = "tbNumberOfElements";
            this.tbNumberOfElements.Size = new System.Drawing.Size(175, 35);
            this.tbNumberOfElements.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Количество элементов";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(697, 632);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 40);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbDesiredValue
            // 
            this.tbDesiredValue.Location = new System.Drawing.Point(251, 481);
            this.tbDesiredValue.Name = "tbDesiredValue";
            this.tbDesiredValue.Size = new System.Drawing.Size(175, 35);
            this.tbDesiredValue.TabIndex = 22;
            // 
            // dgvFinalCoefficients
            // 
            this.dgvFinalCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalCoefficients.Location = new System.Drawing.Point(736, 50);
            this.dgvFinalCoefficients.Name = "dgvFinalCoefficients";
            this.dgvFinalCoefficients.RowHeadersWidth = 72;
            this.dgvFinalCoefficients.RowTemplate.Height = 37;
            this.dgvFinalCoefficients.Size = new System.Drawing.Size(304, 400);
            this.dgvFinalCoefficients.TabIndex = 21;
            // 
            // dgvInitialCoefficients
            // 
            this.dgvInitialCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitialCoefficients.Location = new System.Drawing.Point(369, 50);
            this.dgvInitialCoefficients.Name = "dgvInitialCoefficients";
            this.dgvInitialCoefficients.RowHeadersWidth = 72;
            this.dgvInitialCoefficients.RowTemplate.Height = 37;
            this.dgvInitialCoefficients.Size = new System.Drawing.Size(285, 400);
            this.dgvInitialCoefficients.TabIndex = 20;
            // 
            // dgvInputSignals
            // 
            this.dgvInputSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputSignals.Location = new System.Drawing.Point(12, 50);
            this.dgvInputSignals.Name = "dgvInputSignals";
            this.dgvInputSignals.RowHeadersWidth = 72;
            this.dgvInputSignals.RowTemplate.Height = 37;
            this.dgvInputSignals.Size = new System.Drawing.Size(297, 400);
            this.dgvInputSignals.TabIndex = 19;
            // 
            // labelNumberOfIterations
            // 
            this.labelNumberOfIterations.AutoSize = true;
            this.labelNumberOfIterations.Location = new System.Drawing.Point(865, 481);
            this.labelNumberOfIterations.Name = "labelNumberOfIterations";
            this.labelNumberOfIterations.Size = new System.Drawing.Size(24, 30);
            this.labelNumberOfIterations.TabIndex = 18;
            this.labelNumberOfIterations.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Количество итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Желаемое значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Конечные весовые коэффициенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Первоначальные весовые коэффициенты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Входные сигналы";
            // 
            // function
            // 
            this.function.FormattingEnabled = true;
            this.function.Items.AddRange(new object[] {
            "Униполярная",
            "Биполярная"});
            this.function.Location = new System.Drawing.Point(697, 560);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(212, 38);
            this.function.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 30);
            this.label7.TabIndex = 27;
            this.label7.Text = "η";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(251, 610);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(175, 35);
            this.tbH.TabIndex = 28;
            // 
            // randomCoeff
            // 
            this.randomCoeff.Location = new System.Drawing.Point(523, 632);
            this.randomCoeff.Name = "randomCoeff";
            this.randomCoeff.Size = new System.Drawing.Size(131, 40);
            this.randomCoeff.TabIndex = 29;
            this.randomCoeff.Text = "random";
            this.randomCoeff.UseVisualStyleBackColor = true;
            this.randomCoeff.Click += new System.EventHandler(this.randomCoeff_Click);
            // 
            // startWithRandom
            // 
            this.startWithRandom.Location = new System.Drawing.Point(523, 700);
            this.startWithRandom.Name = "startWithRandom";
            this.startWithRandom.Size = new System.Drawing.Size(305, 40);
            this.startWithRandom.TabIndex = 30;
            this.startWithRandom.Text = "startWithRandom";
            this.startWithRandom.UseVisualStyleBackColor = true;
            this.startWithRandom.Click += new System.EventHandler(this.startWithRandom_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 775);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "ex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 865);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.startWithRandom);
            this.Controls.Add(this.randomCoeff);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.function);
            this.Controls.Add(this.tbNumberOfElements);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbDesiredValue);
            this.Controls.Add(this.dgvFinalCoefficients);
            this.Controls.Add(this.dgvInitialCoefficients);
            this.Controls.Add(this.dgvInputSignals);
            this.Controls.Add(this.labelNumberOfIterations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalCoefficients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialCoefficients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputSignals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNumberOfElements;
        private Label label6;
        private Button btnStart;
        private TextBox tbDesiredValue;
        private DataGridView dgvFinalCoefficients;
        private DataGridView dgvInitialCoefficients;
        private DataGridView dgvInputSignals;
        private Label labelNumberOfIterations;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox function;
        private Label label7;
        private TextBox tbH;
        private Button randomCoeff;
        private Button startWithRandom;
        private Label label8;
    }
}