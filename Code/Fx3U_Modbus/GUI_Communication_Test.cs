using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fx3U_Modbus
{
    public partial class GUI_Communication_Test : Form
    {
        public GUI_Communication_Test()
        {
            InitializeComponent();
        }

        private void GUI_Communication_Test_Load(object sender, EventArgs e)
        {
            cboReadCoilDeviceType.SelectedIndex = 0;
            cboReadRegisterDeviceType.SelectedIndex = 0;
            cboWriteCoilDeviceType.SelectedIndex = 0;
            cboWriteCoilValue.SelectedIndex = 0;
            cboWriteRegisterDeviceType.SelectedIndex = 0;
            txtReadCoidDeviceAddress.Text = "0";
            txtReadRegisterDeviceAddress.Text = "0";
            txtWriteCoidDeviceAddress.Text = "0";
            txtWriteRegisterDeviceAddress.Text = "0";
            txtWriteRegisterlValue.Text = "0";
        }

        private void btnReadSingleCoil_Click(object sender, EventArgs e)
        {
            int address = Convert.ToInt16(txtReadCoidDeviceAddress.Text);
            if(cboReadCoilDeviceType.SelectedItem.ToString() == "M")
            {
                txtReadCoilValue.Text = Modbus_Driver.readSingleCoil((ushort)(address)).ToString();
            }
        }

        private void btnReadRegister_Click(object sender, EventArgs e)
        {
            int address = Convert.ToInt32(txtReadRegisterDeviceAddress.Text);
            txtReadRegisterlValue.Text = Convert.ToString(Modbus_Driver.readRegister((ushort)(address)));
        }

        private void btnwriteSingleCoil_Click(object sender, EventArgs e)
        {
            Modbus_Driver.writeSingleCoil(ushort.Parse(txtWriteCoidDeviceAddress.Text), bool.Parse(cboWriteCoilValue.SelectedItem.ToString()));
        }

        private void btnWriteRegister_Click(object sender, EventArgs e)
        {
            Modbus_Driver.writeRegister(ushort.Parse(txtWriteRegisterDeviceAddress.Text), ushort.Parse(txtWriteRegisterlValue.Text));
        }
    }
}
