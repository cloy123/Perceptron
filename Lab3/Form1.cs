namespace Lab3
{
    public partial class Form1 : Form
    {


        double[] InputSignals = new double[0];
        double[] InitialCoefficients = new double[0];

        public Form1()
        {
            InitializeComponent();
        }



        public void RandomCoefficients(int n)
        {
            InputSignals = new double[n];
            InitialCoefficients = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                InputSignals[i] = rnd.Next(-100, 100) / 100.0;
                dgvInputSignals.Rows[i].Cells[0].Value = InputSignals[i];
                InitialCoefficients[i] = rnd.Next(-100, 100) / 100.0;
                dgvInitialCoefficients.Rows[i].Cells[0].Value = InitialCoefficients[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            function.SelectedIndex = 0;
        }

        public int Teach()
        {
            double d = double.Parse(tbDesiredValue.Text);
            double y;//функци€, перва€ формула
            double yDif;// дифференциал функции, т.е. втора€ формула
            int j = 0;
            int n = Int32.Parse(tbNumberOfElements.Text);
            double H = double.Parse(tbH.Text);//коэффициент обучаемости, который n
            double u = 0;
            double ex; // разница между полученным и желаемым значением, сравниваем с погрешностью
            double pogr = 0.01; // допустима€ погрешность
            double b = 1;//коэффициент, вли€ет на форму функции активации


            double[] x = new double[n]; 
            InputSignals.CopyTo(x, 0);
            double[] w = new double[n];
            InitialCoefficients.CopyTo(w, 0);
            //randomCoefficients(n);

            do
            {
                u = 0;
                for (int i = 0; i < n; i++)
                {
                    u += x[i] * w[i];
                }
                // 0 - унипол€рна€, 1 - бипол€рна€
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
                    //уточнение весовых коэффициентов
                    for (int i = 0; i < n; i++)
                    {
                        double tmp = x[i] * ex * yDif * H;
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
            //int n = Int32.Parse(tbNumberOfElements.Text);
            //dgvFinalCoefficients.RowCount = n;
            //dgvInitialCoefficients.RowCount = n;
            //dgvInputSignals.RowCount = n;
            //RandomCoefficients(n);
            //var sum = 0.0;
            //for (int i = 0; i < 11; i++)
            //{
            //    //RandomCoefficients(n);
            //    sum += Teach();
            //}
            //labelNumberOfIterations.Text = (sum / 11.0).ToString();
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
    }
}