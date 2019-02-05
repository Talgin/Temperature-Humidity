using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace TempHum
{
    public partial class Form1 : Form
    {
        SerialPort sp;
        public Boolean connected = false;

        private string[] ports;
        public string selectedPort;
        public Form1()
        {
            InitializeComponent();
            //sp.BaudRate = 9600;
            string[] ports = SerialPort.GetPortNames();
            tmPorts.Items.AddRange(ports);
        }

        void mainFunc()
        {
            connected = true;
            pbTemp.Visible = true;
            pbTemp.Minimum = 0;
            pbTemp.Maximum = 100;
            pbTemp.Value = 1;
            pbTemp.Step = 1;

            pbHum.Visible = true;
            pbHum.Minimum = 0;
            pbHum.Maximum = 100;
            pbHum.Value = 1;
            pbHum.Step = 1;

            while(connected)
            {
                string[] a = sp.ReadLine().Split('.');
                string[] b = sp.ReadLine().Split('.');                
                
                int temp = int.Parse(a[0]);
                int hum = int.Parse(b[0]);// Convert.ToInt32(sp.ReadLine());
                                
                if (temp > 0)
                {
                    pbTemp.Value = temp;
                    tbTemp.Text = sp.ReadLine();
                }/*
                else
                    MessageBox.Show("temp null");       */         
                if (hum > 0)
                {
                    pbHum.Value = hum;
                    tbHum.Text = sp.ReadLine();                
                }/*
                else
                    MessageBox.Show("hum null");*/               
            }
        }

        private void defineStatus(bool status) //  connected/disconnected
        {
            if (status == true)
            {
                lblStatus.Text = "Қосылған";
                lblStatus.ForeColor = Color.Green;
                //connected = true;
            }
            else
            {
                lblStatus.Text = "Қосылмаған";
                lblStatus.ForeColor = Color.Red;
                //connected = false;
            }
        }        

        private void tmPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPort = tmPorts.SelectedItem.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.ComponentModel.IContainer components = new System.ComponentModel.Container();
                if (tmPorts.SelectedIndex != -1)
                {
                    sp = new System.IO.Ports.SerialPort(components);
                    sp.PortName = selectedPort;
                    sp.BaudRate = 9600;//Int32.Parse(comboBoxBaudRate.SelectedItem.ToString());
                    sp.DtrEnable = true;
                }
                else
                {
                    throw new Exception("Select right BAUD rate!");
                }
                if (!sp.IsOpen)
                {
                    sp.Open();
                    mainFunc();
                    defineStatus(true);
                }
                else
                {
                    sp.Close();                    
                    btnConnectDis.Text = "Қосу";
                    defineStatus(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Could not connect to port. \nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
