using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Database_Connectivity
{
    public partial class PLC : Form
    {
        public PLC()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home window = new Home();
            window.Show();
            this.Hide();
        }

        private void PLC_Load(object sender, EventArgs e)
        {
            button2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;


            button2.Hide();
            button3.Enabled = true;
            button1.Show();

            textBox1.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string plc_ip = textBox1.Text;

            try
            {
                if (!string.IsNullOrEmpty(plc_ip))
                {
                    using (var plc = new Plc(CpuType.S71200, plc_ip, 0, 1))
                    {
                        plc.Open();
                        textBox1.ReadOnly = true;
                        button1.Hide();
                        button2.Show();
                        button3.Enabled = false;
                    }
                }

                else
                {
                    MessageBox.Show("You have must enter PLC IP first!");
                }

            }
            catch
            {
                MessageBox.Show("You entered wrong PLC IP!");
            }
        }
    }
}
