using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace zh_n9rwd5
{

    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook wb;
        Excel.Worksheet ws;
        public Form1()
        {
            InitializeComponent();
        }




        private void buttonVevõk_Click(object sender, EventArgs e)
        {
            vForm vform = new vForm();
            vform.Show();
        }



        private void buttonÜgynökök_Click(object sender, EventArgs e)
        {
            üForm üform = new üForm();
            üform.Show();
        }



        private void buttonRendelések_Click(object sender, EventArgs e)
        {
            rForm rform = new rForm();
            rform.Show();
        }



        private void buttonExcel_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }



        void CreateTable()
        {
            string[] fejléc = new string[]
            {
                "Ügynök azonosító","Ügynök név", "Telefon"
            };
            for (int i = 0; i < fejléc.Count(); i++)
            {
                ws.Cells[1, i + 1] = fejléc[i];
            }
            Models.ZhContext zhContext = new Models.ZhContext();
            var xd = zhContext.Ügynökök.ToList();
            object[,] array = new object[xd.Count, fejléc.Count()];
            for (int i = 0; i < xd.Count(); i++)
            {
                array[i, 0] = xd[i].ÜgynökAzon;
                array[i, 1] = xd[i].ÜgynökNév;
                array[i, 2] = xd[i].Telefon;
            }
            int sorok = array.GetLength(0);
            int oszlopok = array.GetLength(1);
            Excel.Range adatrange = ws.get_Range("A2", Type.Missing).get_Resize(sorok, oszlopok);
            adatrange.Value2 = array;
            Excel.Range fejlécrange = ws.get_Range("A1", Type.Missing).get_Resize(1, 3);
            adatrange.Font.Color = Color.Gray;
            adatrange.Font.Italic = true;
        }



        void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                wb = xlApp.Workbooks.Add(Missing.Value);
                ws = wb.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                wb.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlApp = null;
                wb = null;

            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos bezárod?", "Eskü mûködik, ne lépj ki :(", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}