using System.Data;
using System.Data.SqlClient;

namespace Coke_CIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //login button
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source = 192.168.45.100; Initial Catalog = COKEDB_45_100; User ID = Coke; Password = Coke@2023");
                connection.Open();

                string Username = textBox1.Text;
                string Password = textBox2.Text;

                const string sqlQuery = @"SELECT Display_Name
                FROM Coke_User
                WHERE Username = @Username
                AND Password = @Password;
                ";

                using SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = Username;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = Password;

                string displayName = (string)sqlCommand.ExecuteScalar();

                connection.Close();

                if (Username == "admin" && Password == "admin")
                {
                    Admin window = new Admin();
                    window.Show();
                    this.Hide();
                }
                else
                {
                    if (displayName != null)
                    {
                        UserName.Name = $"{displayName}";
                        //MessageBox.Show(UserName.Name);
                        Data form1 = new Data();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You have entered wrong credentials!");
                    }
                }


            }


            //user login track test start


            catch (Exception)
            {
                MessageBox.Show("Please check Database connectivity first!");
                //throw;
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}