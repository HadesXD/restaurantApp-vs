using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace koncniProjekt
{
    class Item
    {
        public string Ime { set; get; }
        public List<Sestavina> Sestavine;

        public Item(string ime)
        {
            Ime = ime;
            Sestavine = new List<Sestavina>();
        }

        public void AddIng(Sestavina tempSestavina)
        {
            Sestavine.Add(tempSestavina);
        }

        public void BazaVstavi()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "INSERT INTO norme(ime) VALUES ('" + Ime + "');";
                com.ExecuteNonQuery();
                foreach (Sestavina s in Sestavine)
                {
                    com.CommandText = "INSERT INTO sestavine_norme(norma_id, sestavina_id, kolicina) VALUES ((SELECT id FROM norme WHERE ime = '" + Ime + "'), (SELECT id FROM sestavine WHERE ime = '" + s.Ime + "'), " + s.Kolicina + ");";
                    com.ExecuteNonQuery();
                }
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void VsaviSestavine()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "SELECT ns.kolicina, s.ime AS sIme, e.ime AS eIme FROM norme n " +
                    "INNER JOIN sestavine_norme ns ON ns.norma_id=n.id " +
                    "INNER JOIN sestavine s ON s.id=ns.sestavina_id " +
                    "INNER JOIN enote e ON e.id=s.enota_id " +
                    "WHERE n.ime = '" + Ime + "';";
                SQLiteDataReader reader = com.ExecuteReader();
               while (reader.Read())
                {
                    Sestavina temSestavina = new Sestavina(reader.GetString(1), reader.GetFloat(0).ToString(), reader.GetString(2));
                    AddIng(temSestavina);
                }
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Update()
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("data source = database.db");
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "DELETE FROM sestavine_norme WHERE norma_id = (SELECT id FROM norme WHERE ime = '" + Ime + "');";
                com.ExecuteNonQuery();
                foreach (Sestavina s in Sestavine)
                {
                    com.CommandText = "INSERT INTO sestavine_norme(norma_id, sestavina_id, kolicina) VALUES ((SELECT id FROM norme WHERE ime = '" + Ime + "'), (SELECT id FROM sestavine WHERE ime = '" + s.Ime + "'), " + s.Kolicina + ");";
                    com.ExecuteNonQuery();
                }
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
