using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Fx3U_Modbus
{
    public partial class GUI_Home : Form
    {
        SQLiteConnection sqlite_conn;
        public bool runTask = false;
        public int no = 0;
        public GUI_Home()
        {
            InitializeComponent();
        }

        private void GUI_Home_Load(object sender, EventArgs e)
        {
            beginWork();
            //listView.Columns[0].TextAlign = HorizontalAlignment.Center;
            //listView.Columns[1].TextAlign = HorizontalAlignment.Center;
            //listView.Columns[2].TextAlign = HorizontalAlignment.Center;
            //listView.Columns[3].TextAlign = HorizontalAlignment.Center;

            sqlite_conn = createConnection();
            createTable(sqlite_conn);
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM LISTVIEW", sqlite_conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            listView.BeginUpdate();
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["STT"].ToString();
                item.SubItems.Add(row["TIME"].ToString());
                item.SubItems.Add(row["TEMPERATURE"].ToString());
                item.SubItems.Add(row["HUMIDITY"].ToString());
                listView.Items.Add(item);
                no++;
            }
            listView.EndUpdate();
        }
        public static SQLiteConnection createConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlite_conn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return sqlite_conn;
        }
        public static void createTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string cmd = "CREATE TABLE IF NOT EXISTS 'ListView' ('STT'   INTEGER,'Time'  TEXT,'Temperature'   INTEGER,'Humidity'  INTEGER)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = cmd;   
            sqlite_cmd.ExecuteNonQuery();
            cmd = "CREATE TABLE IF NOT EXISTS 'HISTORY' ('Date'  TEXT, 'Time'  TEXT, 'HISTORY'  TEXT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = cmd;
            sqlite_cmd.ExecuteNonQuery();
        }
        private async void beginWork()
        {
            while (true)
            {
                var result = await writeData();
            }
        }
        public async Task<string> writeData()
        {
            await Task.Delay(1000);
            if (runTask)
            {
                Modbus_Driver.writeRegister(50, (ushort)(new Random().Next(100))); //temmp
                Modbus_Driver.writeRegister(55, (ushort)(new Random().Next(100))); //humi
                
                string[] arr = new string[4];
                ListViewItem item;
                no++;
                arr[0] = no.ToString();
                arr[1] = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
                arr[2] = Modbus_Driver.readRegister(60).ToString();
                arr[3] = Modbus_Driver.readRegister(65).ToString();
                lbTemperature.Text = arr[2];
                lbHumidity.Text = arr[3];
                item = new ListViewItem(arr);
                listView.Items.Add(item);

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = string.Format("INSERT INTO ListView (STT, TIME, TEMPERATURE, HUMIDITY) VALUES ('{0}', '{1}', '{2}', '{3}')", arr[0], arr[1], arr[2], arr[3]);
                sqlite_cmd.ExecuteNonQuery();
            }
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            return DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
        }
        private void exportToExcel()
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)ws.get_Range("A1", "B1");
            ws.Cells[3, 3] = "STT";
            ws.Cells[3, 4] = "Time";
            ws.Cells[3, 5] = "Temperature";
            ws.Cells[3, 6] = "Humidity";
            rg.Columns.AutoFit();

            int i = 4;
            int j = 3;

            foreach (ListViewItem comp in listView.Items)
            {
                ws.Cells[i, j] = comp.Text.ToString();
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 3;
                i++;
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            runTask = true;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format("INSERT INTO HISTORY (DATE, TIME, HISTORY) VALUES ('{0}', '{1}', '{2}')", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), "RUN");
            sqlite_cmd.ExecuteNonQuery();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            runTask= false;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format("INSERT INTO HISTORY (DATE, TIME, HISTORY) VALUES ('{0}', '{1}', '{2}')", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), "PAUSE");
            sqlite_cmd.ExecuteNonQuery();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportToExcel();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format("INSERT INTO HISTORY (DATE, TIME, HISTORY) VALUES ('{0}', '{1}', '{2}')", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), "EXPORT EXCEL");
            sqlite_cmd.ExecuteNonQuery();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            no = 0;

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM LISTVIEW";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = string.Format("INSERT INTO HISTORY (DATE, TIME, HISTORY) VALUES ('{0}', '{1}', '{2}')", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), "CLEAR");
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}
