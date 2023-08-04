using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;
using System.Data;
using ClosedXML.Excel;

namespace Coke_CIP
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

        }

        private void button3_Click(object sender, EventArgs e) //logout button
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            label3.Text = UserName.Name;

            int centerX = this.Width / 2;
            int labelX = centerX - (label3.Width / 2);           
            int labelY = 12;
            
            label3.Location = new System.Drawing.Point(labelX, labelY);
        }

        private void button1_Click(object sender, EventArgs e) // show button
        {
            ///*
            try
            {
                SqlConnection connection = new SqlConnection("Data Source = 192.168.45.100; Initial Catalog = COKEDB_45_100; User ID = Coke; Password = Coke@2023");
                connection.Open();

                try
                {
                    SqlCommand selectQuery = new SqlCommand("Select * from Coke_CIP_DataRecord where Date_Time between ' " + dateTimePicker1.Value.ToString() + " ' and ' " + dateTimePicker2.Value.ToString() + " ' ", connection);
                    //SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery);


                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.AllowUserToAddRows = false;

                        if (dataTable.Rows.Count == 0)
                        {
                            label4.Text = $"Data Found: {dataGridView1.Rows.Count}";
                            //dataGridView1.DataSource = null; 
                        }
                        else
                        {
                            label4.Text = $"Data Found: {dataGridView1.Rows.Count}";
                            //dataGridView1.DataSource = dataTable; 
                        }
                    }






                    /*
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AllowUserToAddRows = false;
                    label4.Visible = true;
                    label4.Text = $"Data Found: {dataGridView1.Rows.Count}";
                    */




                    //command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    /*
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AllowUserToAddRows = false;
                    if (dataTable.Rows.Count == 0)
                        {
                            // No data found for the selected date
                            //dataGridView1.DataSource = null; // Clear the data source
                            label4.Text = $"Data Found: {dataGridView1.Rows.Count}";
                        }
                        else
                        {
                             // Bind data to DataGridView
                            label4.Text = $"Data Found: {dataGridView1.Rows.Count}";
                        }
                    }

                */




                }

                catch
                {
                    MessageBox.Show("Data table not found in Database!");
                }

            }

            catch
            {
                MessageBox.Show("Database not found!");
            }
            //*/


            /*
            //2nd
            SqlConnection connection = new SqlConnection("Data Source = 192.168.105.30; Initial Catalog = COKE; User ID = sa; Password = 123456");
            //connection.Open();

            if (connection.State == ConnectionState.Open)
            {

                SqlCommand selectQuery = new SqlCommand("Select * from Coke_CIP_DataRecord_Test where Date_Time between ' " + dateTimePicker1.Value.ToString() + " ' and ' " + dateTimePicker2.Value.ToString() + " ' ", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                label3.Visible = true;
                label3.Text = $"Data Found: {dataGridView1.RowCount}";
            }
            else
            {
                MessageBox.Show("Please check database connectivity!");
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)  //excel button
        {
            //start

            dataGridView1.SelectAll();
            DataObject copyData = dataGridView1.GetClipboardContent();

            if (copyData != null)
            {
                //Creating DataTable
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }

                //Adding the Rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*xlsx" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //MessageBox.Show("1");
                        try
                        {
                            //MessageBox.Show("2");
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                // MessageBox.Show("3");
                                wb.Worksheets.Add(dt, "Coke_CIP_DataRecord");
                                wb.SaveAs(saveFileDialog.FileName + ".xlsx"); //$"Coke_CIP_DataRecord{Guid.NewGuid()}.xlsx");
                            }

                            MessageBox.Show("You have successfully exported your data to an excel file.");
                        }
                        catch
                        {
                            MessageBox.Show("Error Occured!");
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Data found 0, Please try with another Date-Time.");
            }
        }
    }
}
