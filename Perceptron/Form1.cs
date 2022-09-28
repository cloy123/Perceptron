namespace Perceptron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var sum = 0.0;
            for(int i = 0; i < 11; i++)
            {
                sum += Teach();
            }
            labelNumberOfIterations.Text = (sum/11.0).ToString();
        }

        public int Teach()
        {
            int d = Int32.Parse(tbDesiredValue.Text);
            int? y = null;
            int j = 0;
            int n = Int32.Parse(tbNumberOfElements.Text);
            dgvInputSignals.RowCount = n;
            dgvInitialCoefficients.RowCount = n;
            dgvFinalCoefficients.RowCount = n;
            int u = 0;
            int[] x = new int[n];
            int[] w = new int[n];
            int[][] a = new int[2][];
            a[0] = new int[10];
            a[1] = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(-10, 10);
                dgvInputSignals.Rows[i].Cells[0].Value = x[i];
                w[i] = rnd.Next(-100, 100);
                dgvInitialCoefficients.Rows[i].Cells[0].Value = w[i];
            }

            do
            {
                if (y != null)
                {
                    if (y > d)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            w[i] = w[i] - x[i];
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            w[i] = w[i] + x[i];
                        }
                    }
                }

                u = 0;
                for (int i = 0; i < n; i++)
                {
                    u += x[i] * w[i];
                }

                if (u >= 0)
                {
                    y = 1;
                }
                else
                {
                    y = 0;
                }
                j++;
            }
            while (y != d);
            for (int i = 0; i < w.Length; i++)
            {
                dgvFinalCoefficients.Rows[i].Cells[0].Value = w[i];
            }
            labelNumberOfIterations.Text = j.ToString();
            for (int i = 0; i < a.Length; i++)
            {
                if (j != 1)
                {
                    a[0][i] = n;
                    a[1][i] = j;
                }
            }
            return j;
        }
    }
}