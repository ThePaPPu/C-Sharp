using System.Data.SqlClient;
using System.Windows.Forms;


namespace Database_Connectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)  //Connect Button
        {
            try
            {

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (!string.IsNullOrEmpty(textBox2.Text))
                    {
                        if (!string.IsNullOrEmpty(textBox4.Text))
                        {
                            if (!string.IsNullOrEmpty(textBox5.Text))
                            {
                                string databaseIP = textBox1.Text;
                                string databaseName = textBox2.Text;
                                string username = textBox4.Text;
                                string password = textBox5.Text;


                                //string database_Connection = $"Data Source= "+ textBox1.Text +"; Initial Catalog= "+ textBox2.Text +";User ID= "+ textBox4.Text +";Password="+ textBox5.Text +";";
                                string database_Connection = $"Data Source={databaseIP}; Initial Catalog={databaseName};User ID={username};Password={password}";

                                MessageBox.Show(database_Connection);

                                SqlConnection sqlConnection = new SqlConnection(database_Connection);
                                sqlConnection.Open();
                                //button1.Text = "Connected";
                                button1.Hide();
                                button2.Show();
                                textBox1.ReadOnly = true;
                                textBox2.ReadOnly = true;
                                textBox4.ReadOnly = true;
                                textBox5.ReadOnly = true;
                                button3.Enabled = false;
                                sqlConnection.Close();
                            }
                            else
                            {
                                MessageBox.Show("Password must required!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username must required!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Database Name must required!");
                    }
                }
                else
                {
                    MessageBox.Show("Database IP must required!");
                }



            }

            catch (Exception)
            {
                MessageBox.Show("Database not found!!");
            }
        }

        private void enter(object sender, KeyEventArgs e)  //Enter button define for press Connect Button
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            //button2.Text = "Disconne";

            button2.Hide();
            button3.Enabled = true;
            button1.Show();

            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home window = new Home();
            window.Show();
            this.Hide();
        }
    }
}