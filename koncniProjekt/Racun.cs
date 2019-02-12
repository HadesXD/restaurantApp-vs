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

namespace koncniProjekt
{
    public partial class Racun : MetroFramework.Forms.MetroForm
    {

        public Racun()
        {
            InitializeComponent();
            ReadFromBase();
        }

        bool sestavina = false;
        Item trenutniIzdelek;

        private void Racun_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonDodaj_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                trenutniIzdelek = new Item(comboBox1.Text);
                listBox1.Items.Clear();
                sestavina = true;
                trenutniIzdelek.VsaviSestavine();
                foreach(Sestavina s in trenutniIzdelek.Sestavine)
                {
                    listBox1.Items.Add(s.izpis());
                }
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
                        Sestavina ses = new Sestavina("","","");
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

        public void ReadFromBase()
        {
            try
            {
                comboBox1.Items.Clear();
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "Select n.ime AS normeIme FROM norme n ";
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

        private void buttonZaracunaj_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                foreach (Sestavina s in trenutniIzdelek.Sestavine)
                {
                    com.CommandText = "INSERT INTO arhiv_sprememb(sestavina_id, cas_sremembe, kolicina) " +
                        "VALUES((SELECT id FROM sestavine WHERE ime = '" + s.Ime + "'), '" + DateTime.Now + "', " + s.Kolicina + ");";
                    com.ExecuteNonQuery();
                    com.CommandText = "Update sestavine SET skupna_kolicina = skupna_kolicina - " + s.Kolicina + " WHERE ime = '" + s.Ime + "';";
                    com.ExecuteNonQuery();
                }
                com.Dispose();
                conn.Close();
                poenostavi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void poenostavi()
        {
            ReadFromBase();
            comboBox1.Text = "";
            listBox1.Items.Clear();
            bool sestavina = false;
            Item trenutniIzdelek;
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
