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
    public partial class urejanjeDodajanjeSestavin : MetroFramework.Forms.MetroForm
    {
        public urejanjeDodajanjeSestavin()
        {
            InitializeComponent();
            izBaze();
        }

        public bool namen = true;

        public void izBaze()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "Select ime From sestavine;";
                SQLiteDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxSestavina.Items.Add(reader.GetString(0));
                }
                com.Dispose();
                com.CommandText = "Select ime FROm enote";
                SQLiteDataReader reader1 = com.ExecuteReader();
                while (reader1.Read())
                {
                    comboBoxEnota.Items.Add(reader1.GetString(0));
                }
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxSestavina_KeyUp(object sender, KeyEventArgs e)
        {
            int index;
            string actual;
            string found;
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Down) || (e.KeyCode == Keys.PageUp) || (e.KeyCode == Keys.PageDown) || (e.KeyCode == Keys.Home) || (e.KeyCode == Keys.End))
            {

            }
            else
            {
                actual = comboBoxSestavina.Text;
                index = comboBoxSestavina.FindString(actual);
                if (index > -1)
                {
                    found = comboBoxSestavina.Items[index].ToString();
                    comboBoxSestavina.SelectedIndex = index;
                    comboBoxSestavina.SelectionStart = actual.Length;
                    comboBoxSestavina.SelectionLength = found.Length;
                }
            }
        }
    }
}
