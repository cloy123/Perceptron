namespace Perceptron
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNumberOfIterations = new System.Windows.Forms.Label();
            this.dgvInputSignals = new System.Windows.Forms.DataGridView();
            this.dgvInitialCoefficients = new System.Windows.Forms.DataGridView();
            this.dgvFinalCoefficients = new System.Windows.Forms.DataGridView();
            this.tbDesiredValue = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumberOfElements = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputSignals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialCoefficients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalCoefficients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входные сигналы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Первоначальные весовые коэффициенты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Конечные весовые коэффициенты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Желаемое значение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество итераций";
            // 
            // labelNumberOfIterations
            // 
            this.labelNumberOfIterations.AutoSize = true;
            this.labelNumberOfIterations.Location = new System.Drawing.Point(865, 485);
            this.labelNumberOfIterations.Name = "labelNumberOfIterations";
            this.labelNumberOfIterations.Size = new System.Drawing.Size(24, 30);
            this.labelNumberOfIterations.TabIndex = 5;
            this.labelNumberOfIterations.Text = "0";
            // 
            // dgvInputSignals
            // 
            this.dgvInputSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputSignals.Location = new System.Drawing.Point(12, 54);
            this.dgvInputSignals.Name = "dgvInputSignals";
            this.dgvInputSignals.RowHeadersWidth = 72;
            this.dgvInputSignals.RowTemplate.Height = 37;
            this.dgvInputSignals.Size = new System.Drawing.Size(215, 400);
            this.dgvInputSignals.TabIndex = 6;
            // 
            // dgvInitialCoefficients
            // 
            this.dgvInitialCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitialCoefficients.Location = new System.Drawing.Point(369, 54);
            this.dgvInitialCoefficients.Name = "dgvInitialCoefficients";
            this.dgvInitialCoefficients.RowHeadersWidth = 72;
            this.dgvInitialCoefficients.RowTemplate.Height = 37;
            this.dgvInitialCoefficients.Size = new System.Drawing.Size(215, 400);
            this.dgvInitialCoefficients.TabIndex = 7;
            // 
            // dgvFinalCoefficients
            // 
            this.dgvFinalCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalCoefficients.Location = new System.Drawing.Point(781, 54);
            this.dgvFinalCoefficients.Name = "dgvFinalCoefficients";
            this.dgvFinalCoefficients.RowHeadersWidth = 72;
            this.dgvFinalCoefficients.RowTemplate.Height = 37;
            this.dgvFinalCoefficients.Size = new System.Drawing.Size(215, 400);
            this.dgvFinalCoefficients.TabIndex = 8;
            // 
            // tbDesiredValue
            // 
            this.tbDesiredValue.Location = new System.Drawing.Point(251, 485);
            this.tbDesiredValue.Name = "tbDesiredValue";
            this.tbDesiredValue.Size = new System.Drawing.Size(175, 35);
            this.tbDesiredValue.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(523, 562);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 40);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество элементов";
            // 
            // tbNumberOfElements
            // 
            this.tbNumberOfElements.Location = new System.Drawing.Point(251, 547);
            this.tbNumberOfElements.Name = "tbNumberOfElements";
            this.tbNumberOfElements.Size = new System.Drawing.Size(175, 35);
            this.tbNumberOfElements.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 639);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputSignals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitialCoefficients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalCoefficients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelNumberOfIterations;
        private DataGridView dgvInputSignals;
        private DataGridView dgvInitialCoefficients;
        private DataGridView dgvFinalCoefficients;
        private TextBox tbDesiredValue;
        private Button btnStart;
        private Label label6;
        private TextBox tbNumberOfElements;
    }
}