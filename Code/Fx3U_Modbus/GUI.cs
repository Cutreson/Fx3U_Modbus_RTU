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
    public partial class GUI : Form
    {

        public GUI()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void GUI_Load(object sender, EventArgs e)
        {
            openChildForm(new GUI_Home());
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Home());
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Login gui_Login = new GUI_Login();
            gui_Login.ShowDialog();
            this.Close();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GUI_Connection gui_Connection = new GUI_Connection();
                gui_Connection.Show();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Modbus_Driver.disconnect())
            {
                MessageBox.Show("Disconnected", "Connection");
            }
            else
            {
                MessageBox.Show("Error", "Connection");
            }
        }

        private void communicationTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_Communication_Test());
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI_History());
        }
    }
}
