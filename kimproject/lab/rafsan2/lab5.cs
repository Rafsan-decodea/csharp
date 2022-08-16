namespace rafsan2
{
    public partial class lab5 : Form
    {
        public lab5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(facultyeee.Checked)
            {

                string department = "";
                if(departcse.Checked && departeee.Checked)
                {
                    department = department +" "+ departcse.Text + " AND " + departeee.Text;

                }
                else if(departcse.Checked)
                {
                    department = department + departcse.Text;
                }
                else if (departcse.Checked)
                {
                    department = department + departcse.Text;
                }
                else if (departeee.Checked)
                {
                    department = department + departeee.Text;
                }
                else
                {
                    MessageBox.Show("Invalide Department");
                }

                 string data = "Faculty = EEE || Department" + department;
                resultbox.Items.Add(data);
            }

            if (facultyme.Checked)
            {

                string department = "";
                if (departme.Checked || departcfe.Checked || departipe.Checked || departte.Checked)
                {
                   if (departme.Checked)
                    {
                        department = department + " " + departme.Text;
                    }
                    if (departcfe.Checked)
                    {
                        department = department + " " + departcfe.Text;
                    }
                    if (departipe.Checked)
                    {
                        department = department + " " + departipe.Text;
                    }
                    if (departte.Checked)
                    {
                        department = department + " " + departte.Text;
                    }

                }
               
                else
                {
                    MessageBox.Show("Invalide Department");
                }

                string data = "Faculty = ME || Department" + department;
                resultbox.Items.Add(data);
            }


        }
    }
}
