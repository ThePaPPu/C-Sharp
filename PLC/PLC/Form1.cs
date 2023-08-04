using S7.Net;
using System;
using System.Data.SqlClient;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connect();
        }

        public void Connect()
        {
            button1.Text = "Connected";
            button1.BackColor = Color.LightSeaGreen;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)  //connect button
        {
            //const string plc_ip = "172.17.107.95";
            const string plc_ip = "10.7.0.200";

            try
            {
                using (var plc = new Plc(CpuType.S71200, plc_ip, 0, 1))
                {
                    plc.Open();

                    try
                    {
                        double Caustic_Percent = ((uint)plc.Read("DB10.DBD64")).ConvertToFloat();
                        double Feed_Temperature = ((uint)plc.Read("DB10.DBD16")).ConvertToFloat();
                        double Return_Temperature = ((uint)plc.Read("DB10.DBD40")).ConvertToFloat();
                        //int Step_Select = Convert.ToInt32(plc.Read("DB17.DBW2"));
                        string Step_Select = Convert.ToString(plc.Read("DB17.DBW2"));
                        string Tank_Filler_Select = Convert.ToString(plc.Read("DB17.DBW20"));
                        string Auto_Manual = Convert.ToString(plc.Read("DB17.DBX0.1"));
                        //bool Auto_Start = ((bool)plc.Read("DB17.DBX0.4"));
                        string Auto_Start = Convert.ToString(plc.Read("DB17.DBX0.4"));

                        //bool Step_1 = ((bool)plc.Read("DB17.DBX18.0"));
                        string Step_1 = Convert.ToString(plc.Read("DB17.DBX18.0"));

                        string Step_2 = Convert.ToString(plc.Read("DB17.DBX18.2"));
                        string Step_3 = Convert.ToString(plc.Read("DB17.DBX18.4"));
                        string Step_4 = Convert.ToString(plc.Read("DB17.DBX18.6"));
                        string Step_5 = Convert.ToString(plc.Read("DB17.DBX19.2"));
                        string Normal_Water = Convert.ToString(plc.Read("Q0.4"));
                        string Hot_Water = Convert.ToString(plc.Read("Q0.6"));
                        string Caustic_Water = Convert.ToString(plc.Read("Q0.7"));


                        if (Step_Select == "1")
                        {
                            Step_Select = "Step-1";
                        }
                        else if (Step_Select == "2")
                        {
                            Step_Select = "Step-2";
                        }
                        else if (Step_Select == "3")
                        {
                            Step_Select = "Step-3";
                        }
                        else if (Step_Select == "4")
                        {
                            Step_Select = "Step-4";
                        }
                        else if (Step_Select == "5")
                        {
                            Step_Select = "Step-5";
                        }
                        else
                        {
                            Step_Select = "Wrong-Step";
                        }

                        if (Tank_Filler_Select == "1")
                        {
                            Tank_Filler_Select = "Tank-1";
                        }
                        else if (Tank_Filler_Select == "2")
                        {
                            Tank_Filler_Select = "Tank-2";
                        }
                        else if (Tank_Filler_Select == "3")
                        {
                            Tank_Filler_Select = "Tank-3";
                        }
                        else if (Tank_Filler_Select == "4")
                        {
                            Tank_Filler_Select = "Filler-3";
                        }
                        else
                        {
                            Tank_Filler_Select = "Wrong";
                        }

                        if (Step_1 == "true")
                        {
                            Step_1 = "On";
                        }
                        else
                        {
                            Step_1 = "Off";
                        }

                        if (Step_2 == "true")
                        {
                            Step_2 = "On";
                        }
                        else
                        {
                            Step_2 = "Off";
                        }

                        if (Step_3 == "true")
                        {
                            Step_3 = "On";
                        }
                        else
                        {
                            Step_3 = "Off";
                        }

                        if (Step_4 == "true")
                        {
                            Step_4 = "On";
                        }
                        else
                        {
                            Step_4 = "Off";
                        }

                        if (Step_5 == "true")
                        {
                            Step_5 = "On";
                        }
                        else
                        {
                            Step_5 = "Off";
                        }

                        if (Normal_Water == "true")
                        {
                            Normal_Water = "On";
                        }
                        else
                        {
                            Normal_Water = "Off";
                        }

                        if (Hot_Water == "true")
                        {
                            Hot_Water = "On";
                        }
                        else
                        {
                            Hot_Water = "Off";
                        }

                        if (Caustic_Water == "true")
                        {
                            Caustic_Water = "On";
                        }
                        else
                        {
                            Caustic_Water = "Off";
                        }

                        if (Auto_Start == "true")
                        {
                            Auto_Start = "On";
                        }
                        else
                        {
                            Auto_Start = "Off";
                        }


                        if (Auto_Manual == "true")
                        {
                            Auto_Manual = "Auto";
                        }
                        else
                        {
                            Auto_Manual = "Manual";
                        }



                        //textBox1.Text = $"{Test_Data.ToString("0.00")}";
                        label17.Text = $"{Caustic_Percent.ToString("0.00000")}";
                        label18.Text = $"{Feed_Temperature.ToString("0.000")}";
                        label19.Text = $"{Return_Temperature.ToString("0.000")}";
                        label20.Text = $"{Step_Select.ToString()}";
                        label21.Text = $"{Tank_Filler_Select.ToString()}";
                        label22.Text = $"{Auto_Manual.ToString()}";
                        label23.Text = $"{Auto_Start.ToString()}";
                        label24.Text = $"{Step_1.ToString()}";
                        label25.Text = $"{Step_2.ToString()}";
                        label26.Text = $"{Step_3.ToString()}";
                        label27.Text = $"{Step_4.ToString()}";
                        label28.Text = $"{Step_5.ToString()}";
                        label29.Text = $"{Normal_Water.ToString()}";
                        label30.Text = $"{Hot_Water.ToString()}";
                        label31.Text = $"{Caustic_Water.ToString()}";



                        const string connectionString = "Data Source = 192.168.105.30; Initial Catalog = testDB; User ID = sa; Password = 123456";


                        const string insertQuery = "INSERT INTO Coke_CIP_DataRecord_Test (Caustic_Percent,Feed_Temperature,Return_Temperature,Step_Select,Tank_Filler_Select,Auto_Manual,Auto_Start,Step_1,Step_2,Step_3,Step_4,Step_5,Normal_Water,Hot_Water,Caustic_Water) " +
                            "VALUES (@Caustic_Percent,@Feed_Temperature,@Return_Temperature,@Step_Select,@Tank_Filler_Select,@Auto_Manual,@Auto_Start,@Step_1,@Step_2,@Step_3,@Step_4,@Step_5,@Normal_Water,@Hot_Water,@Caustic_Water)";

                        const string countQuery = "SELECT COUNT(Primary_Id) FROM Coke_CIP_DataRecord_Test";
                        //



                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Caustic_Percent", label17.Text);
                                command.Parameters.AddWithValue("@Feed_Temperature", label18.Text);
                                command.Parameters.AddWithValue("@Return_Temperature", label19.Text);
                                command.Parameters.AddWithValue("@Step_Select", label20.Text);
                                command.Parameters.AddWithValue("@Tank_Filler_Select", label21.Text);
                                command.Parameters.AddWithValue("@Auto_Manual", label22.Text);
                                command.Parameters.AddWithValue("@Auto_Start", label23.Text);
                                command.Parameters.AddWithValue("@Step_1", label24.Text);
                                command.Parameters.AddWithValue("@Step_2", label25.Text);
                                command.Parameters.AddWithValue("@Step_3", label26.Text);
                                command.Parameters.AddWithValue("@Step_4", label27.Text);
                                command.Parameters.AddWithValue("@Step_5", label28.Text);
                                command.Parameters.AddWithValue("@Normal_Water", label29.Text);
                                command.Parameters.AddWithValue("@Hot_Water", label30.Text);
                                command.Parameters.AddWithValue("@Caustic_Water", label31.Text);

                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                                //MessageBox.Show("Successfully Inserted");

                                //label2.Text = $"Data Found: {dataGridView1.RowCount}";


                                using (SqlCommand cmdCount = new SqlCommand(countQuery, connection))
                                {
                                    connection.Open();
                                    int count = 0;
                                    count = (int)cmdCount.ExecuteScalar();
                                    label2.Text = $"Total Data Inserted: {count}";
                                }


                            }

                        }


                        //
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Pappu");
                    }

                    plc.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Config Load", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine(ex.Message);
            }

            //txtCurrentTemperature.Text = temperature.ToString("0.00");
            //txtSetTemperature.Text = setTemperature.ToString("0.00");
            //txtInterval.Text = smsInterval.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private static System.Timers.Timer timer;
        private void Form1_Load(object sender, EventArgs e)
        {

            //static Timer timer = new Timers();

            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(button1_Click);
            //timer.Elapsed -= new ElapsedEventHandler(button2_Click);
            timer.AutoReset = true;
            timer.SynchronizingObject = this;
            timer.Interval = 10000;

            timer.Enabled = true;


        }

    }
}