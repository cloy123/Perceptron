namespace Lab44
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
            this.dgvX = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvW1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvW2 = new System.Windows.Forms.DataGridView();
            this.dgvW4 = new System.Windows.Forms.DataGridView();
            this.dgvW3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btTeach = new System.Windows.Forms.Button();
            this.tbPol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            // 
            // dgvX
            // 
            this.dgvX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvX.Location = new System.Drawing.Point(65, 97);
            this.dgvX.Name = "dgvX";
            this.dgvX.RowHeadersWidth = 72;
            this.dgvX.RowTemplate.Height = 37;
            this.dgvX.Size = new System.Drawing.Size(494, 351);
            this.dgvX.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "0"});
            this.comboBox1.Location = new System.Drawing.Point(65, 484);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 38);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvW1
            // 
            this.dgvW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW1.Location = new System.Drawing.Point(691, 97);
            this.dgvW1.Name = "dgvW1";
            this.dgvW1.RowHeadersWidth = 72;
            this.dgvW1.RowTemplate.Height = 37;
            this.dgvW1.Size = new System.Drawing.Size(547, 351);
            this.dgvW1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "W1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1356, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "W2";
            // 
            // dgvW2
            // 
            this.dgvW2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW2.Location = new System.Drawing.Point(1356, 97);
            this.dgvW2.Name = "dgvW2";
            this.dgvW2.RowHeadersWidth = 72;
            this.dgvW2.RowTemplate.Height = 37;
            this.dgvW2.Size = new System.Drawing.Size(524, 351);
            this.dgvW2.TabIndex = 6;
            // 
            // dgvW4
            // 
            this.dgvW4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW4.Location = new System.Drawing.Point(1356, 542);
            this.dgvW4.Name = "dgvW4";
            this.dgvW4.RowHeadersWidth = 72;
            this.dgvW4.RowTemplate.Height = 37;
            this.dgvW4.Size = new System.Drawing.Size(524, 351);
            this.dgvW4.TabIndex = 7;
            // 
            // dgvW3
            // 
            this.dgvW3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW3.Location = new System.Drawing.Point(691, 555);
            this.dgvW3.Name = "dgvW3";
            this.dgvW3.RowHeadersWidth = 72;
            this.dgvW3.RowTemplate.Height = 37;
            this.dgvW3.Size = new System.Drawing.Size(547, 351);
            this.dgvW3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1396, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "W4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "W3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "распознать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btTeach
            // 
            this.btTeach.Location = new System.Drawing.Point(65, 625);
            this.btTeach.Name = "btTeach";
            this.btTeach.Size = new System.Drawing.Size(156, 40);
            this.btTeach.TabIndex = 12;
            this.btTeach.Text = "обучить";
            this.btTeach.UseVisualStyleBackColor = true;
            this.btTeach.Click += new System.EventHandler(this.btTeach_Click);
            // 
            // tbPol
            // 
            this.tbPol.Location = new System.Drawing.Point(131, 555);
            this.tbPol.Name = "tbPol";
            this.tbPol.Size = new System.Drawing.Size(175, 35);
            this.tbPol.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "pol";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(491, 635);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(64, 30);
            this.result.TabIndex = 15;
            this.result.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1993, 932);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPol);
            this.Controls.Add(this.btTeach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvW3);
            this.Controls.Add(this.dgvW4);
            this.Controls.Add(this.dgvW2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvW1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvX;
        private ComboBox comboBox1;
        private DataGridView dgvW1;
        private Label label2;
        private Label label3;
        private DataGridView dgvW2;
        private DataGridView dgvW4;
        private DataGridView dgvW3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button btTeach;
        private TextBox tbPol;
        private Label label6;
        private Label result;
    }
}