namespace Lab3
{
    public partial class Form1 : Form
    {


        double[] X = new double[0];
        double[] W = new double[0];

        public Form1()
        {
            InitializeComponent();
        }



        public void RandomCoefficients(int n)
        {
            X = new double[n];
            W = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                X[i] = rnd.Next(-100, 100) / 100.0;
                dgvInputSignals.Rows[i].Cells[0].Value = X[i];
                W[i] = rnd.Next(-100, 100) / 100.0;
                dgvInitialCoefficients.Rows[i].Cells[0].Value = W[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            function.SelectedIndex = 0;
        }

        public int Teach()
        {
            double d = double.Parse(tbDesiredValue.Text);
            double y;//�������, ������ �������
            double yDif;// ������������ �������, �.�. ������ �������
            int j = 0;
            int n = Int32.Parse(tbNumberOfElements.Text);
            double H = double.Parse(tbH.Text);//����������� �����������, ������� n
            double u = 0;
            double ex; // ������� ����� ���������� � �������� ���������, ���������� � ������������
            double pogr = 0.01; // ���������� �����������
            double b = 1;//�����������, ������ �� ����� ������� ���������

            double[] x = new double[n]; 
            X.CopyTo(x, 0);
            double[] w = new double[n];
            W.CopyTo(w, 0);

            do
            {
                u = 0;
                for (int i = 0; i < n; i++)
                {
                    u += x[i] * w[i];
                }
                // 0 - �����������, 1 - ����������
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
                    //��������� ������� �������������
                    for (int i = 0; i < n; i++)
                    {
                        double tmp = x[i] * ex * yDif * H;
                        w[i] = w[i] - tmp;
                    }
                }
            }
            while (Math.Abs(ex) >= pogr && j < 100000);
            label8.Text = "ex = " + ex.ToString();
            for (int i = 0; i < w.Length; i++)
            {
                dgvFinalCoefficients.Rows[i].Cells[0].Value = w[i];
            }
            labelNumberOfIterations.Text = j.ToString();
            return j;
        }

        public int TeachWithRandom()
        {
            double d = double.Parse(tbDesiredValue.Text);
            double y;//�������, ������ �������
            double yDif;// ������������ �������, �.�. ������ �������
            int j = 0;
            int n = Int32.Parse(tbNumberOfElements.Text);
            double H = double.Parse(tbH.Text);//����������� �����������, ������� n
            double u = 0;
            double ex; // ������� ����� ���������� � �������� ���������, ���������� � ������������
            double pogr = 0.1; // ���������� �����������
            double b = 1;//�����������, ������ �� ����� ������� ���������

            RandomCoefficients(n);

            double[] x = new double[n];
            X.CopyTo(x, 0);
            double[] w = new double[n];
            W.CopyTo(w, 0);
            

            do
            {
                u = 0;
                for (int i = 0; i < n; i++)
                {
                    u += x[i] * w[i];
                }
                // 0 - �����������, 1 - ����������
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
                    //��������� ������� �������������
                    for (int i = 0; i < n; i++)
                    {
                        double tmp = x[i] * ex * yDif * H;
                        w[i] = w[i] - tmp;
                    }
                }
            }
            while (Math.Abs(ex) >= pogr && j < 100000);
            label8.Text = "ex = " + ex.ToString();
            for (int i = 0; i < w.Length; i++)
            {
                dgvFinalCoefficients.Rows[i].Cells[0].Value = w[i];
            }
            labelNumberOfIterations.Text = j.ToString();
            return j;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Teach();
        }

        private void randomCoeff_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(tbNumberOfElements.Text);
            dgvFinalCoefficients.RowCount = n;
            dgvInitialCoefficients.RowCount = n;
            dgvInputSignals.RowCount = n;
            RandomCoefficients(n);
        }

        private void startWithRandom_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(tbNumberOfElements.Text);
            dgvFinalCoefficients.RowCount = n;
            dgvInitialCoefficients.RowCount = n;
            dgvInputSignals.RowCount = n;
            //var sum = 0.0;
            //for (int i = 0; i < 11; i++)
            //{
            //    sum += TeachWithRandom();
            //}
            //labelNumberOfIterations.Text = (sum / 11.0).ToString();
            TeachWithRandom();
        }
    }
}