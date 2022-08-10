namespace rafsan2
{
    public partial class bar : Form
    {
        public bar()
        {
            InitializeComponent();
        }

        private void bar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(fristnumber.Text);
            double text2 = Convert.ToDouble(secoundnumber.Text);
            double result = text1 + text2;
            resultshow.Text = result.ToString();

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (facultycomboBox.Text == "EEE")
            {
                if (departmentcomboBox.Text == "EEE" || departmentcomboBox.Text == "CSE")
                {
                    if (EEE.Items.Count == 0) // This is cheking if There is an
                    {
                        EEE.Items.Add(stuname.Text + "-" + stuid.Text + "-" + departmentcomboBox.Text);
                    }
                    else
                    {
                        for (int i = EEE.Items.Count - 1; i >= 0; i--)
                        {
                            if (EEE.Items.IndexOf(EEE.Items[i].ToString()) < i)
                            {
                                EEE.Items.Add(stuname.Text + "-" + stuid.Text + "-" + departmentcomboBox.Text);
                            }
                            else
                            {
                                MessageBox.Show("Duplicate Value Detected");
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalide Department Choosen");
                }
            }
            else if (facultycomboBox.Text == "ME")
            {
                if (departmentcomboBox.Text == "ME" || departmentcomboBox.Text == "CFE" || departmentcomboBox.Text == "IPE" || departmentcomboBox.Text == "TE")
                {
                    if (ME.Items.Count == 0) // This is cheking if There is no value
                    {
                        ME.Items.Add(stuname.Text + "-" + stuid.Text + "-" + departmentcomboBox.Text);
                    }
                    else
                    {
                        for (int i = ME.Items.Count - 1; i >= 0; i--)// This is cheking if There is  Duplicate Value
                        {
                            if (ME.Items.IndexOf(ME.Items[i].ToString()) < i)
                            {
                                ME.Items.Add(stuname.Text + "-" + stuid.Text + "-" + departmentcomboBox.Text);
                            }
                            else
                            {
                                MessageBox.Show("Duplicate Value Detected");
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalide Department Choosen");
                }

            }
            else if(facultycomboBox.Text=="CE") {

                if (departmentcomboBox.Text == "CE" || departmentcomboBox.Text == "ARCH")
                {
                    if (CE.Items.Count == 0) // This is cheking if There is an
                    {
                        CE.Items.Add(stuname.Text + "-" + stuid.Text + "-" + departmentcomboBox.Text);
                    }
                    else
                    {
                        for (int i = CE.Items.Count - 1; i >= 0; i--)
                        {
                            if (CE.Items.IndexOf(CE.Items[i].ToString()) < i)
                            {
                                CE.Items.Add(stuname.Text + "-" + stuid.Text + "-" + departmentcomboBox.Text);
                            }
                            else
                            {
                                MessageBox.Show("Duplicate Value Detected");
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalide Department Choosen");
                }


            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void EEE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}