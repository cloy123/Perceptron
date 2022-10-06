namespace Lab5
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
            double y;
            double N = 0.1;
            double l = N / 3;
            int b = 4;
            int a = 3;
            int c = 4;
            dataGridView1.RowCount = a;
            dataGridView2.RowCount = a;
            dataGridView3.RowCount = c;
            dataGridView1.ColumnCount = b;
            dataGridView2.ColumnCount = b;
            dataGridView3.ColumnCount = b;
            double u;
            double pol = 0.5;
            double[,] x = { { 1, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 1, 0, 1 } };
            double[,] w = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            Random rnd = new Random();
            int t = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = x[i, j];
                }
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = x[i, j];
                }
            }


            do
            {
                for (int i = 0; i < a; i++)
                {
                    u = 0;
                    for (int k = 0; k < c; k++)
                    {
                        u = 0;
                        for (int m = 0; m < b; m++) 
                        { 
                            u += x[i, m] * w[k, m]; 
                        }
                        if (u > pol)
                        {
                            y = 1;
                        }
                        else
                        {
                            y = 0;
                        }
                        for (int s = 0; s < b; s++)
                        {
                            w[k, s] = w[k, s] * (1 - l) + N * x[i, s] * y;
                        }
                    }
                }

                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        dataGridView3.Rows[i].Cells[j].Value = w[i, j];
                    }
                }
                t++;
            }
            while (t < 10);
            labelNumberOfIterations.Text = t.ToString();
        }
        
    }
}