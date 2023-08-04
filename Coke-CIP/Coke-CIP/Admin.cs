using System.Data.SqlClient;

namespace Coke_CIP
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)  //logout button
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)  //create user button
        {

            string Username = Convert.ToString(textBox1.Text);
            string Password = Convert.ToString(textBox2.Text);
            string Display_Name = Convert.ToString(textBox3.Text);
            DateTime date1 = DateTime.Now;


            string connectionString = "Data Source = 192.168.45.100; Initial Catalog = COKEDB_45_100; User ID = Coke; Password = Coke@2023";
            string insertQuery = "INSERT INTO Coke_User (Username, Password, Display_Name, Created_At) VALUES (@Username, @Password, @Display_Name, @Created_At)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand check_User = new SqlCommand("SELECT COUNT(*) FROM Coke_User WHERE (Username = @Username)", connection);
                check_User.Parameters.AddWithValue("@Username", textBox1.Text);
                int UserExist = (int)check_User.ExecuteScalar();

                if (UserExist < 1)
                {

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Display_Name", Display_Name);
                        command.Parameters.AddWithValue("@Created_At", date1);

                        if (string.IsNullOrEmpty(Username))
                        {
                            MessageBox.Show("You have must enter Username!");
                            textBox1.Focus();
                        }
                        else if (string.IsNullOrEmpty(Password))
                        {
                            MessageBox.Show("You have must enter Password!");
                            textBox2.Focus();
                        }
                        else if (string.IsNullOrEmpty(Display_Name))
                        {
                            MessageBox.Show("You have must enter Display_Name!");
                            textBox3.Focus();
                            textBox3.Focus();
                        }
                        else
                        {
                            //connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Successfully User created for Mr. " + Display_Name);

                            textBox1.Text = string.Empty;
                            textBox2.Text = string.Empty;
                            textBox3.Text = string.Empty;
                        }

                    }
                }

                else
                {
                    MessageBox.Show(textBox1.Text + " user already exist in Database!!");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }



        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
