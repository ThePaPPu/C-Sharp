using System.Data.SqlClient;
using System.Reflection.Metadata;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Test_Data_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Parameter_1 = "P-1";
            string Parameter_2 = "P-2";
            string Parameter_3 = "P-3";

            if (Parameter_1 == "P-2")
            {
                Parameter_1 = "If";
            }
            else
            {
                Parameter_1 = "Else";
            }


            try
            {
                const string database_Connection = @"Data Source=10.5.0.135; Initial Catalog=PappuDB;User ID=Pappu;Password=123456";
                const string insertQuery = "INSERT INTO Test_Table (Parameter_1, Parameter_2, Parameter_3) VALUES (@Parameter_1, @Parameter_2, @Parameter_3)";
                using (SqlConnection sqlConnection = new SqlConnection(database_Connection))
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, sqlConnection))
                    {
                        sqlConnection.Open();

                        command.Parameters.AddWithValue("@Parameter_1", Parameter_1);
                        command.Parameters.AddWithValue("@Parameter_2", Parameter_2);
                        command.Parameters.AddWithValue("@Parameter_3", Parameter_3);

                        command.ExecuteNonQuery();
                        sqlConnection.Close();

                        textBox1.Text = Parameter_1;

                        button1.Text = "Sent";
                        button1.Enabled = false;
                    }
                        
                    
                    //MessageBox.Show("Successfully connected to " + databaseName);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Database not found!!");
            }
        }
    }
}