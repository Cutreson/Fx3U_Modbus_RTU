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

namespace Fx3U_Modbus 
{
    public partial class GUI_Connection : Form
    {

        public GUI_Connection()
        {
            InitializeComponent();
        }

        private void GUI_Connection_Load(object sender, EventArgs e)
        {
            showPorts();
            string[] ports = SerialPort.GetPortNames();
            if(ports.Length != 0) cboPorts.SelectedIndex = 0;
            cboBaudRate.SelectedIndex = 3;
            txtSlaveID.Text = "1";
        }
        public void showPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            try
            {
                Array.Sort(ports);
                foreach (string port in ports)
                {
                    cboPorts.Items.Add(port);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string portName = cboPorts.SelectedItem.ToString();
            int baudRate = Convert.ToInt32(cboBaudRate.SelectedItem.ToString());
            byte slaveID = Convert.ToByte(txtSlaveID.Text);
            if(Modbus_Driver.connect(portName, baudRate, slaveID))
            {
                MessageBox.Show("Connected", "Connection");
            }
            else
            {
                MessageBox.Show("Error", "Connection");
            }
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
