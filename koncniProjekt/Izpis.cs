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
using Excel = Microsoft.Office.Interop.Excel;

namespace koncniProjekt
{
    public partial class Izpis : MetroFramework.Forms.MetroForm
    {
        public Izpis()
        {
            InitializeComponent();
            izBaze();
        }

        private void Izpis_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form f in System.Windows.Forms.Application.OpenForms)
            {
                if (f.Name == "menuForm")
                {
                    f.Visible = true;
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    SQLiteConnection conn = new SQLiteConnection("data source = database.db;datetimeformat=CurrentCulture");
                    conn.Open();
                    SQLiteCommand com = new SQLiteCommand(conn);
                    if (comboBox1.Text == "Arhiv")
                    {
                        com.CommandText = "SELECT s.ime AS Sestavina, sa.cas_sremembe AS 'Datum spremembe', sa.kolicina AS Količina FROM arhiv_sprememb sa INNER JOIN sestavine s ON sa.sestavina_id=s.id; ";
                    }
                    else if (comboBox1.Text == "Pregled zaloge")
                    {
                        com.CommandText = "SELECT s.ime AS Sestavina, s.skupna_kolicina AS 'Preostala količina', e.ime FROM sestavine s INNER JOIN enote e ON e.id=s.enota_id;";
                    }
                    else
                    {
                        com.CommandText = "SELECT s.ime AS Sestavina, s.skupna_kolicina AS 'Preostala količina', e.ime FROM sestavine s INNER JOIN enote e ON e.id=s.enota_id INNER JOIN kategorije k ON k.id=s.kategorija_id WHERE k.ime = '" + comboBox1.Text + "';";
                    }
                    DataSet ds = new DataSet();
                    var da = new SQLiteDataAdapter(com.CommandText, conn);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    buttonExport.Enabled = true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                Excel._Application app = new Excel.Application();
                Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["List1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Izpis";
                

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1,i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if(dataGridView1.Rows[i].Cells[j].Value != null)
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
               

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "izvoz";
                saveFileDialog.DefaultExt = ".xlsx";
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void izBaze()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("data source = database.db;datetimeformat=CurrentCulture");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "SELECT ime FROM kategorije";
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Down) || (e.KeyCode == Keys.PageUp) || (e.KeyCode == Keys.PageDown) || (e.KeyCode == Keys.Home) || (e.KeyCode == Keys.End))
            {

            }
            else
            {
                actual = comboBox1.Text;
                index = comboBox1.FindString(actual);
                if (index > -1)
                {
                    found = comboBox1.Items[index].ToString();
                    comboBox1.SelectedIndex = index;
                    comboBox1.SelectionStart = actual.Length;
                    comboBox1.SelectionLength = found.Length;
                }
            }
        }
    }
}