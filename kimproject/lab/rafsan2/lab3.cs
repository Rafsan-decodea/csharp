namespace rafsan2
{
    public partial class lab3 : Form
    {
        public lab3()
        {
            InitializeComponent();
        }

        private void lab3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(box1.Text);
            double text2 = Convert.ToDouble(box2.Text);
            double resultt = text1 + text2;
            result.Text = resultt.ToString();
        }
    }
}
