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
    public partial class UrejanjeNorm : MetroFramework.Forms.MetroForm
    {
        public UrejanjeNorm()
        {
            InitializeComponent();
            izBaze();
        }

        private void UrejanjeNorm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "menuForm")
                {
                    f.Visible = true;
                    break;
                }
            }
        }

        bool sestavina = false;
        bool dodajanje = false;
        Item trenutniIzdelek;

        private void addFieldbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sestavina)
                {
                    urejanjeDodajanjeSestavin tempForm = new urejanjeDodajanjeSestavin();
                    tempForm.ShowDialog();
                    if (tempForm.DialogResult == DialogResult.OK)
                    {
                        Sestavina tempsestavina = new Sestavina(tempForm.comboBoxSestavina.Text, tempForm.textBoxKolicina.Text, tempForm.comboBoxEnota.Text);
                        trenutniIzdelek.AddIng(tempsestavina);
                        listBox1.Items.Add(tempsestavina.izpis());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chooseNormmetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                trenutniIzdelek = new Item(comboBox1.Text);
                sestavina = true;
                dodajanje = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = this.listBox1.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    string currentSelectedItem = listBox1.Items[index].ToString();
                    string[] seperateStrings1 = currentSelectedItem.Split(',');
                    string[] seperateStrings2 = seperateStrings1[1].Split(' ');
                    urejanjeDodajanjeSestavin tempForm = new urejanjeDodajanjeSestavin();
                    tempForm.comboBoxSestavina.Text = seperateStrings1[0];
                    tempForm.textBoxKolicina.Text = seperateStrings2[0];
                    tempForm.comboBoxEnota.Text = seperateStrings2[1];
                    tempForm.ShowDialog();
                    if (tempForm.DialogResult == DialogResult.OK)
                    {
                        Sestavina ses = new Sestavina("", "", "");
                        foreach (Sestavina s in trenutniIzdelek.Sestavine)
                        {
                            if (s.Ime == seperateStrings1[0] && s.Kolicina == seperateStrings2[0] && s.Enota == seperateStrings2[1])
                            {
                                ses = s;
                                break;
                            }
                        }
                        trenutniIzdelek.Sestavine.Remove(ses);
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        Sestavina tempsestavina = new Sestavina(tempForm.comboBoxSestavina.Text, tempForm.textBoxKolicina.Text, tempForm.comboBoxEnota.Text);
                        trenutniIzdelek.AddIng(tempsestavina);
                        listBox1.Items.Add(tempsestavina.izpis());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNormbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Ime tempIme = new Ime();
                tempIme.ShowDialog();
                if (tempIme.DialogResult == DialogResult.OK)
                {
                    comboBox1.Text = tempIme.textBoxIme.Text;
                    trenutniIzdelek = new Item(tempIme.textBoxIme.Text);
                    listBox1.Items.Clear();
                    dodajanje = true;
                    sestavina = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            if (dodajanje)
            {
                trenutniIzdelek.BazaVstavi();
            }
            else if (!dodajanje)
            {
                trenutniIzdelek.Update();
            }
            refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            sestavina = true;
            trenutniIzdelek = new Item(comboBox1.Text);
            trenutniIzdelek.VsaviSestavine();
            foreach (Sestavina s in trenutniIzdelek.Sestavine)
            {
                listBox1.Items.Add(s.izpis());
            }
        }

        public void izBaze()
        {
            try
            {
                comboBox1.Items.Clear();
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "Select n.ime AS normeIme FROM norme n Order By n.ime ";
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

        public void refresh()
        {
            izBaze();
            comboBox1.Text = "";
            listBox1.Items.Clear();
            bool dodajanje = false;
            bool sestavina = false;
            Item trenutniIzdelek;
        }

        private void buttonIzbrisiNormo_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                try
                {
                    SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                    conn.Open();
                    SQLiteCommand com = new SQLiteCommand(conn);
                    com.CommandText = "DELETE FROM sestavine_norme WHERE norma_id = (SELECT id FROM norme WHERE ime = '" + comboBox1.Text + "');";
                    com.ExecuteNonQuery();
                    com.CommandText = "DELETE FROM norme WHERE ime = '" + comboBox1.Text + "';";
                    com.ExecuteNonQuery();
                    com.Dispose();
                    conn.Close();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Izberi normo!");
            }
        }

        private void buttonIzbrisiPolje_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                string currentSelectedItem = listBox1.SelectedItem.ToString();
                string[] seperateStrings1 = currentSelectedItem.Split(',');
                string[] seperateStrings2 = seperateStrings1[1].Split(' ');
                Sestavina ses = new Sestavina("", "", "");
                foreach (Sestavina s in trenutniIzdelek.Sestavine)
                {
                    if (s.Ime == seperateStrings1[0] && s.Kolicina == seperateStrings2[0] && s.Enota == seperateStrings2[1])
                    {
                        ses = s;
                        break;
                    }
                }
                trenutniIzdelek.Sestavine.Remove(ses);
                listBox1.Items.Remove(listBox1.SelectedItem);
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V svoji vrstici: \n [ime norme] [sestavina 1] [kolicina 1] [sestavina 2] [kolicina 2] ... \nPozor! Sestavine morajo biti ze vnesene");
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

                    string imeNorme = "";
                    string imeSestavine = "";


                    for (rCnt = 1; rCnt <= rw; rCnt++)
                    {
                        for (cCnt = 1; cCnt <= cl; cCnt++)
                        {
                            str = Convert.ToString((range.Cells[rCnt, cCnt] as Excel.Range).Value2);
                            
                            if (str != null)
                            {
                                //MessageBox.Show(str);
                                if (cCnt == 1)
                                {
                                    imeNorme = str;
                                    com.CommandText = "INSERT INTO norme(ime) VALUES ('" + str + "');";
                                    com.ExecuteNonQuery();
                                }
                                else if ((cCnt % 2) == 0)
                                {
                                    imeSestavine = str;
                                }
                                else
                                {
                                    com.CommandText = "INSERT INTO sestavine_norme(norma_id, sestavina_id, kolicina) VALUES ((SELECT id FROM norme WHERE ime = '" + imeNorme + "'), " +
                                       "(SELECT id FROM sestavine WHERE ime = '" + imeSestavine + "'), " + str + ");";
                                    com.ExecuteNonQuery();
                                }
                            }
                        }
                        //MessageBox.Show("Norma : " + imeNorme + "\nSestavina: " + imeSestavine);
                    }
                    com.Dispose();
                    conn.Close();
                    xlWorkBook.Close(true, null, null);
                    xlApp.Quit();
                    refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
