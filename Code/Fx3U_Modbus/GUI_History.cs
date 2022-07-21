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
    public partial class GUI_History : Form
    {
        SQLiteConnection sqlite_conn;
        public GUI_History()
        {
            InitializeComponent();
        }

        private void GUI_History_Load(object sender, EventArgs e)
        {

            sqlite_conn = createConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT * FROM HISTORY", sqlite_conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            listViewHistory.BeginUpdate();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["DATE"].ToString();
                item.SubItems.Add(row["TIME"].ToString());
                item.SubItems.Add(row["HISTORY"].ToString());
                listViewHistory.Items.Add(item);
            }
            listViewHistory.EndUpdate();
        }
        public static SQLiteConnection createConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return sqlite_conn;
        }
        private void exportToExcel()
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range rg = (Microsoft.Office.Interop.Excel.Range)ws.get_Range("A1", "B1");
            ws.Cells[3, 3] = "Date";
            ws.Cells[3, 4] = "Time";
            ws.Cells[3, 5] = "History";
            rg.Columns.AutoFit();

            int i = 4;
            int j = 3;

            foreach (ListViewItem comp in listViewHistory.Items)
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            listViewHistory.Items.Clear();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM HISTORY";
            sqlite_cmd.ExecuteNonQuery();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportToExcel();
        }
    }
}
