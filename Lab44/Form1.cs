namespace Lab44
{
    public partial class Form1 : Form
    {

        double[] c4 = new double[] {1, 0, 1,
                                    1, 0, 1,
                                    1, 1, 1,
                                    0, 0, 1,
                                    0, 0, 1};

        double[] c6 = new double[] {1, 1, 1,
                                    1, 0, 0,
                                    1, 1, 1,
                                    1, 0, 1,
                                    1, 1, 1};
        double[] c8 = new double[] {1, 1, 1,
                                    1, 0, 1,
                                    1, 1, 1,
                                    1, 0, 1,
                                    1, 1, 1};
        double[] c0 = new double[] {1, 1, 1,
                                    1, 0, 1,
                                    1, 0, 1,
                                    1, 0, 1,
                                    1, 1, 1};

        double[] startW = new double[] {0, 0, 0,
                                    0, 0, 0,
                                    0, 0, 0,
                                    0, 0, 0,
                                    0, 0, 0};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvX.ColumnCount = 3;
            dgvW1.ColumnCount = 3;
            dgvW2.ColumnCount = 3;
            dgvW3.ColumnCount = 3;
            dgvW4.ColumnCount = 3;

            dgvX.RowCount = 5;
            dgvW1.RowCount = 5;
            dgvW2.RowCount = 5;
            dgvW3.RowCount = 5;
            dgvW4.RowCount = 5;

            comboBox1.SelectedIndex = 0;

            SetX(c4);
            SetW(startW, 0);
            SetW(startW, 1);
            SetW(startW, 2);
            SetW(startW, 3);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    SetX(c4);
                    break;
                case 1:
                    SetX(c6);
                    break;
                case 2:
                    SetX(c8);
                    break;
                case 3:
                    SetX(c0);
                    break;
            }
        }

        private void btTeach_Click(object sender, EventArgs e)
        {
            double[] w = GetW(comboBox1.SelectedIndex);
            double[] x = GetX();
            double sumX = 0;
            double pol = double.Parse(tbPol.Text);
            foreach (double d in x)
            {
                sumX += d;
            }
            for (int i = 0; i < w.Length; i++)
            {
                x[i] = x[i] / Math.Sqrt(sumX);
                w[i] = w[i] + (pol * (x[i] - w[i]));
            }
            SetW(w, comboBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] x = GetX();
            double[] w1 = GetW(0);
            double[] w2 = GetW(1);
            double[] w3 = GetW(2);
            double[] w4 = GetW(3);
            double sumX = 0;
            double sumW1 = 0;
            double sumW2 = 0;
            double sumW3 = 0;
            double sumW4 = 0;
            foreach (double d in x)
            {
                sumX += d;
            }
            for (int i = 0; i < w1.Length; i++)
            {
                x[i] = x[i] / Math.Sqrt(sumX);
                sumW1 += x[i] * w1[i];
                sumW2 += x[i] * w2[i];
                sumW3 += x[i] * w3[i];
                sumW4 += x[i] * w4[i];
            }

            List<double> results = new List<double>() { sumW1, sumW2, sumW3, sumW4 };
            result.Text = comboBox1.Items[results.FindIndex(d => d == results.Max())].ToString();
        }

        private void SetX(double[] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dgvX.Rows[i].Cells[j].Value = arr[i * 3 + j];
                }
            }
        }

        private double[] GetX()
        {
            double[] arr = new double[15];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i * 3 + j] = double.Parse(dgvX.Rows[i].Cells[j].Value.ToString());
                }
            }
            return arr;
        }

        private DataGridView GetWdgv(int index)
        {
            switch (index)
            {
                case 0:
                    return dgvW1;
                case 1:
                    return dgvW2;
                case 2:
                    return dgvW3;
                case 3:
                    return dgvW4;
                default:
                    return dgvW1;
            }
        }

        private void SetW(double[] arr, int index)
        {
            var dgv = GetWdgv(index);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dgv.Rows[i].Cells[j].Value = arr[i * 3 + j];
                }
            }
        }

        private double[] GetW(int index)
        {
            double[] arr = new double[15];
            var dgv = GetWdgv(index);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i * 3 + j] = double.Parse(dgv.Rows[i].Cells[j].Value.ToString());
                }
            }
            return arr;
        }
    }
}