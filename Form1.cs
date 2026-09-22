namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                object calculation = new System.Data.DataTable().Compute(Result.Text, "");
                Result.Text = calculation.ToString();
            }
            catch (Exception ex)
            {
                Result.Text = "Error";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "+";
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "*";
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "/";
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "6";
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += "0";
        }
        private void Decimal_Click(object sender, EventArgs e)
        {
            if (Result.Text == "Error") Result.Text = "";
            Result.Text += ".";
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Result.Text = "";
        }

      
    }
}

