namespace Lab4
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
            this.tbd1 = new System.Windows.Forms.TextBox();
            this.dgvFinalCoefficients = new System.Windows.Forms.DataGridView();
            this.dgvInitialCoefficients = new System.Windows.Forms.DataGridView();
            this.dgvInputSignals = new System.Windows.Forms.DataGridView();
            this.labelNumberOfIterations = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbd2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPol = new System.Windows.Forms.TextBox();
            this.random = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalCoefficients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialCoefficients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputSignals)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumberOfElements
            // 
            this.tbNumberOfElements.Location = new System.Drawing.Point(258, 499);
            this.tbNumberOfElements.Name = "tbNumberOfElements";
            this.tbNumberOfElements.Size = new System.Drawing.Size(175, 35);
            this.tbNumberOfElements.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Количество элементов";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(693, 644);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 40);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbd1
            // 
            this.tbd1.Location = new System.Drawing.Point(77, 616);
            this.tbd1.Name = "tbd1";
            this.tbd1.Size = new System.Drawing.Size(96, 35);
            this.tbd1.TabIndex = 22;
            // 
            // dgvFinalCoefficients
            // 
            this.dgvFinalCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalCoefficients.Location = new System.Drawing.Point(788, 68);
            this.dgvFinalCoefficients.Name = "dgvFinalCoefficients";
            this.dgvFinalCoefficients.RowHeadersWidth = 72;
            this.dgvFinalCoefficients.RowTemplate.Height = 37;
            this.dgvFinalCoefficients.Size = new System.Drawing.Size(312, 400);
            this.dgvFinalCoefficients.TabIndex = 21;
            // 
            // dgvInitialCoefficients
            // 
            this.dgvInitialCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitialCoefficients.Location = new System.Drawing.Point(376, 68);
            this.dgvInitialCoefficients.Name = "dgvInitialCoefficients";
            this.dgvInitialCoefficients.RowHeadersWidth = 72;
            this.dgvInitialCoefficients.RowTemplate.Height = 37;
            this.dgvInitialCoefficients.Size = new System.Drawing.Size(309, 400);
            this.dgvInitialCoefficients.TabIndex = 20;
            // 
            // dgvInputSignals
            // 
            this.dgvInputSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputSignals.Location = new System.Drawing.Point(19, 68);
            this.dgvInputSignals.Name = "dgvInputSignals";
            this.dgvInputSignals.RowHeadersWidth = 72;
            this.dgvInputSignals.RowTemplate.Height = 37;
            this.dgvInputSignals.Size = new System.Drawing.Size(273, 400);
            this.dgvInputSignals.TabIndex = 19;
            // 
            // labelNumberOfIterations
            // 
            this.labelNumberOfIterations.AutoSize = true;
            this.labelNumberOfIterations.Location = new System.Drawing.Point(872, 499);
            this.labelNumberOfIterations.Name = "labelNumberOfIterations";
            this.labelNumberOfIterations.Size = new System.Drawing.Size(24, 30);
            this.labelNumberOfIterations.TabIndex = 18;
            this.labelNumberOfIterations.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Количество итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "d1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Конечные весовые коэффициенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Первоначальные весовые коэффициенты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Входные сигналы";
            // 
            // tbd2
            // 
            this.tbd2.Location = new System.Drawing.Point(77, 668);
            this.tbd2.Name = "tbd2";
            this.tbd2.Size = new System.Drawing.Size(96, 35);
            this.tbd2.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 673);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 30);
            this.label7.TabIndex = 26;
            this.label7.Text = "d2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "pol";
            // 
            // tbPol
            // 
            this.tbPol.Location = new System.Drawing.Point(258, 553);
            this.tbPol.Name = "tbPol";
            this.tbPol.Size = new System.Drawing.Size(96, 35);
            this.tbPol.TabIndex = 29;
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(530, 644);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(131, 40);
            this.random.TabIndex = 30;
            this.random.Text = "random";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "startWithRandom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 835);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.random);
            this.Controls.Add(this.tbPol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbd2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNumberOfElements);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbd1);
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
        private TextBox tbd1;
        private DataGridView dgvFinalCoefficients;
        private DataGridView dgvInitialCoefficients;
        private DataGridView dgvInputSignals;
        private Label labelNumberOfIterations;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbd2;
        private Label label7;
        private Label label8;
        private TextBox tbPol;
        private Button random;
        private Button button1;
    }
}