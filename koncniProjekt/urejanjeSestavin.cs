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
    public partial class urejanjeSestavin : MetroFramework.Forms.MetroForm
    {
        public urejanjeSestavin()
        {
            InitializeComponent();
            izBaze();
        }

        private void urejanjeSestavin_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f.Name == "menuForm")
                {
                    f.Visible = true;
                    break;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "INSERT INTO sestavine(enota_id, ime, skupna_kolicina, kategorija_id) VALUES ((SELECT id FROM enote WHERE ime = '" + comboBoxEnote.Text + "'), '" + imeTextBox.Text + "', " + textBoxKolicina.Text + ", (SELECT id FROM kategorije WHERE ime = '" + comboBoxKategorije.Text + "'));";
                com.ExecuteNonQuery();
                com.Dispose();
                conn.Close();
                fresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void izBaze()
        {
            try
            {
                comboBox1.Items.Clear();
                comboBoxEnote.Items.Clear();
                comboBoxKategorije.Items.Clear();
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "SELECT ime FROm sestavine;";
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }
                reader.Close();
                com.CommandText = "SELECT ime FROM enote;";
                SQLiteDataReader reader1 = com.ExecuteReader();
                while (reader1.Read())
                {
                    comboBoxEnote.Items.Add(reader1.GetString(0));
                }
                reader1.Close();
                com.CommandText = "SELECT ime FROM kategorije;";
                SQLiteDataReader reader2 = com.ExecuteReader();
                while (reader2.Read())
                {
                    comboBoxKategorije.Items.Add(reader2.GetString(0));
                }
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fresh()
        {
            izBaze();
            comboBox1.Text = "";
            comboBoxEnote.Text = "";
            comboBoxKategorije.Text = "";
            textBoxKolicina.Text = "";
            imeTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    urejanjeDodajanjeSestavin tempForm = new urejanjeDodajanjeSestavin();
                    SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                    conn.Open();
                    SQLiteCommand com = new SQLiteCommand(conn);
                    com.CommandText = "SELECT s.skupna_kolicina, e.ime FROM sestavine s INNER JOIN enote e ON e.id=s.enota_id WHERE s.ime = '" + comboBox1.Text + "' LIMIT 1;";
                    SQLiteDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        tempForm.textBoxKolicina.Text = reader.GetValue(0).ToString();
                        tempForm.comboBoxEnota.Text = reader.GetString(1);
                        tempForm.comboBoxSestavina.Text = comboBox1.Text;
                    }
                    reader.Close();
                    tempForm.ShowDialog();
                    if (tempForm.DialogResult == DialogResult.OK)
                    {
                       com.CommandText = "UPDATE sestavine SET skupna_kolicina = " + tempForm.textBoxKolicina.Text + ", ime = '" + tempForm.comboBoxSestavina.Text + "', enota_id = (SELECT id FROM enote WHERE ime = '" + tempForm.comboBoxEnota.Text + "') WHERE ime = '" + comboBox1.Text + "';";
                        com.ExecuteNonQuery();
                    }
                    com.Dispose();
                    conn.Close();
                    fresh();
                }
                else
                {
                    MessageBox.Show("Izberite sestavino!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                    conn.Open();
                    SQLiteCommand com = new SQLiteCommand(conn);
                    com.CommandText = "DELETE FROM sestavine_norme WHERE sestavina_id = (SELECT id FROM sestavine WHERE ime = '" + comboBox1.Text + "');";
                    com.ExecuteNonQuery();
                    com.CommandText = "DELETE FROM arhiv_sprememb WHERE sestavina_id = (SELECT id FROM sestavine WHERE ime = '" + comboBox1.Text + "');";
                    com.ExecuteNonQuery();
                    com.CommandText = "DELETE FROM sestavine WHERE ime = '" + comboBox1.Text + "'";
                    com.ExecuteNonQuery();
                    com.Dispose();
                    conn.Close();
                    fresh();
                }
                else
                {
                    MessageBox.Show("Izberite sestavino!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonKategorija_Click(object sender, EventArgs e)
        {
            try
            {
                Ime tempIme = new Ime();
                tempIme.ShowDialog();
                if (tempIme.DialogResult == DialogResult.OK)
                {
                    if (tempIme.textBoxIme.Text != "")
                    {
                        SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                        conn.Open();
                        SQLiteCommand com = new SQLiteCommand(conn);
                        com.CommandText = "INSERT INTO kategorije(ime) VALUES('" + tempIme.textBoxIme.Text + "');";
                        com.ExecuteNonQuery();
                        com.Dispose();
                        conn.Close();
                        fresh();
                    }
                    else
                    {
                        MessageBox.Show("Vpisite ime!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEnota_Click(object sender, EventArgs e)
        {
            try
            {
                Ime tempIme = new Ime();
                tempIme.ShowDialog();
                if (tempIme.DialogResult == DialogResult.OK)
                {
                    if (tempIme.textBoxIme.Text != "")
                    {
                        SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                        conn.Open();
                        SQLiteCommand com = new SQLiteCommand(conn);
                        com.CommandText = "INSERT INTO enote(ime) VALUES('" + tempIme.textBoxIme.Text + "');";
                        com.ExecuteNonQuery();
                        com.Dispose();
                        conn.Close();
                        fresh();
                    }
                    else
                    {
                        MessageBox.Show("Vpisite ime!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kolicinaIzBaze()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "SELECT skupna_kolicina FROM sestavine WHERE ime = '" + comboBox1.Text + "';";
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    labelKolicinaSestavine.Text = "Kolicina: " + reader.GetValue(0).ToString();
                }
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPristej_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxVnos.Text != "")
                {
                    double tempF = Convert.ToDouble(textBoxVnos.Text);
                    SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                    conn.Open();
                    SQLiteCommand com = new SQLiteCommand(conn);
                    com.CommandText = "UPDATE sestavine SET skupna_kolicina = skupna_kolicina + " + tempF + " WHERE ime = '" + comboBox1.Text + "';";
                    com.ExecuteNonQuery();
                    com.Dispose();
                    conn.Close();
                    kolicinaIzBaze();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kolicinaIzBaze();
            textBoxVnos.Enabled = true;
            buttonPristej.Enabled = true;
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;
            if((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Down) || (e.KeyCode == Keys.PageUp) || (e.KeyCode == Keys.PageDown) || (e.KeyCode == Keys.Home) || (e.KeyCode == Keys.End)){

            }
            else
            {
                actual = comboBox1.Text;
                index = comboBox1.FindString(actual);
                if(index > -1)
                {
                    found = comboBox1.Items[index].ToString();
                    comboBox1.SelectedIndex = index;
                    comboBox1.SelectionStart = actual.Length;
                    comboBox1.SelectionLength = found.Length;
                }
            }
        }

        private void comboBoxKategorije_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Down) || (e.KeyCode == Keys.PageUp) || (e.KeyCode == Keys.PageDown) || (e.KeyCode == Keys.Home) || (e.KeyCode == Keys.End))
            {

            }
            else
            {
                actual = comboBoxKategorije.Text;
                index = comboBoxKategorije.FindString(actual);
                if (index > -1)
                {
                    found = comboBox1.Items[index].ToString();
                    comboBoxKategorije.SelectedIndex = index;
                    comboBoxKategorije.SelectionStart = actual.Length;
                    comboBoxKategorije.SelectionLength = found.Length;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vzorec za uvoz sestavin: \n [sestavina 1] [kolicina 1] [enota 1] [kategorija 1] \n [sestavina 2] [kolicina 2] [enota 2] [kategorija 1] \nPozor! Enote in kategorije morajo biti ze vnesene.");
        }

        private void buttonMassInport_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;

                string str;
                int rCnt;
                int cCnt;
                int rw = 0;
                int cl = 0;

                OpenFileDialog openTempDialog = new OpenFileDialog();

                if (openTempDialog.ShowDialog() == DialogResult.OK)
                {
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(openTempDialog.FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    range = xlWorkSheet.UsedRange;
                    rw = range.Rows.Count;
                    cl = range.Columns.Count;

                    SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                    conn.Open();
                    SQLiteCommand com = new SQLiteCommand(conn);
                    

                    string imeSestavine = "";
                    string imeEnote = "";
                    string skupnaKolicina = "";
                    string imeKategorije = "";


                    for (rCnt = 1; rCnt <= rw; rCnt++)
                    {
                        for (cCnt = 1; cCnt <= cl; cCnt++)
                        {
                            str = Convert.ToString((range.Cells[rCnt, cCnt] as Excel.Range).Value2);

                            if (str != null)
                            {
                                //MessageBox.Show(str);
                                switch (cCnt)
                                {
                                    case 1:
                                        imeSestavine = str;
                                        break;
                                    case 2:
                                        skupnaKolicina = str;
                                        break;
                                    case 3:
                                        imeEnote = str;
                                        break;
                                    case 4:
                                        imeKategorije = str;
                                        break;
                                    default:
                                        MessageBox.Show("Napaka");
                                        break;

                                }
                            }
                        }
                        if(checkBoxIzbris.Checked == true)
                        {
                            com.CommandText = "DELETE FROM sestavine_norme;";
                            com.ExecuteNonQuery();
                            com.CommandText = "DELETE FROM sestavine;";
                            com.ExecuteNonQuery();
                        }
                        com.CommandText = "INSERT INTO sestavine(enota_id, ime, skupna_kolicina, kategorija_id) VALUES ((SELECT id FROM enote WHERE ime = '" + imeEnote + "'), '" + imeSestavine + "', " + skupnaKolicina + ", (SELECT id FROM kategorije WHERE ime = '" + imeKategorije + "'));";
                        com.ExecuteNonQuery();
                        //MessageBox.Show("Norma : " + imeNorme + "\nSestavina: " + imeSestavine);
                    }
                    com.Dispose();
                    conn.Close();
                    xlWorkBook.Close(true, null, null);
                    xlApp.Quit();
                    fresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
