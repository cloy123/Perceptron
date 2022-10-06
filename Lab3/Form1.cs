namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            function.SelectedIndex = 0;
        }

        public int Teach()
        {
            double d = double.Parse(tbDesiredValue.Text);
            double y;
            double yDif;
            int j = 0;
            int n = Int32.Parse(tbNumberOfElements.Text);
            dgvFinalCoefficients.RowCount = n;
            dgvInitialCoefficients.RowCount = n;
            dgvInputSignals.RowCount = n;
            double u = 0;
            double ex;
            double pogr = 0.001;
            double b = 0.5;
            double[] x = new double[n];
            double[] w = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = rnd.Next(-100, 100) / 100.0;
                dgvInputSignals.Rows[i].Cells[0].Value = x[i];
                w[i] = rnd.Next(-100, 100) / 100.0;
                dgvInitialCoefficients.Rows[i].Cells[0].Value = w[i];
            }

            do
            {
                u = 0;
                for (int i = 0; i < n; i++)
                {
                    u += x[i] * w[i];
                }
                if (function.SelectedIndex == 0)
                {
                    y = 1 / (1 + Math.Exp(-b * u));
                    yDif = (b * y * (1 - y));
                }
                else
                {
                    y = Math.Tanh(b * u);
                    yDif = b * (1 - Math.Pow(y, 2));
                }
                j++;
                ex = y - d;

                if (Math.Abs(ex) >= pogr)
                {
                    for (int i = 0; i < n; i++)
                    {
                        double tmp = x[i] * ex * yDif;
                        w[i] = w[i] - tmp;
                    }
                }
            }
            while (Math.Abs(ex) >= pogr);
            for (int i = 0; i < w.Length; i++)
            {
                dgvFinalCoefficients.Rows[i].Cells[0].Value = w[i];
            }
            labelNumberOfIterations.Text = j.ToString();
            return j;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Teach();
            var sum = 0.0;
            for (int i = 0; i < 11; i++)
            {
                sum += Teach();
            }
            labelNumberOfIterations.Text = (sum / 11.0).ToString();
        }
    }
}