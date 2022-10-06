namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Teach();
        }

        public void Teach()
        {
            double y1;
            double y2;
            double N = 0.5;
            double q1 = 0;
            double q2 = 0;
            int n = Int32.Parse(tbNumberOfElements.Text);
            dgvInputSignals.RowCount = n;
            dgvInitialCoefficients.RowCount = n;
            dgvFinalCoefficients.RowCount = n;
            double u1;
            double u2;
            double d1 = double.Parse(tbd1.Text);
            double d2 = double.Parse(tbd2.Text);
            double pol = 0.9;
            double[,] x = new double[2, n];
            double[] w = new double[n];
            int j = 0;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[0, i] = rnd.Next(-100, 100);
                q1 += Math.Pow(x[0, i], 2);
                x[1, i] = rnd.Next(-100, 100);
                q2 += Math.Pow(x[1, i], 2);
                w[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                x[0, i] = x[0, i] / (Math.Pow(q1, 0.5));
                dgvInputSignals.Rows[i].Cells[0].Value = x[0, i];
                x[1, i] = x[1, i] / (Math.Pow(q2, 0.5));
                dgvInitialCoefficients.Rows[i].Cells[0].Value = x[1, i];
            }
            do
            {
                u1 = 0;
                u2 = 0;
                for (int i = 0; i < n; i++)
                {
                    u1 += x[0, i] * w[i];
                    u2 += x[1, i] * w[i];
                }

                if (u1 < pol)
                {
                    y1 = 0;
                }
                else 
                { 
                    y1 = 1; 
                }

                if (u2 < pol)
                {
                    y2 = 0;
                }
                else
                {
                    y2 = 1;
                }

                for (int i = 0; i < n; i++)
                {
                    w[i] += N * d1 * (x[0, i] - w[i]);
                    w[i] += N * d2 * (x[1, i] - w[i]);
                }
                j++;
            }
            while (y1 != d1 || y2 != d2);

            for (int i = 0; i < n; i++)
            {
                dgvFinalCoefficients.Rows[i].Cells[0].Value = w[i];
            }
            labelNumberOfIterations.Text = j.ToString();
        }

    }
}