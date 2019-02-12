using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koncniProjekt
{
    public partial class menuForm : MetroFramework.Forms.MetroForm
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void outputbutton_Click(object sender, EventArgs e)
        {
            Izpis tempIspis = new Izpis();
            tempIspis.Show();
            this.Hide();
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            Racun tempRacun = new Racun();
            tempRacun.Show();
            this.Hide();
        }

        private void addEditNormsbutton_Click(object sender, EventArgs e)
        {
            UrejanjeNorm tempNorme = new UrejanjeNorm();
            tempNorme.Show();
            this.Hide();
        }

        private void addEditIngbutton_Click(object sender, EventArgs e)
        {
            urejanjeSestavin tempSestavine = new urejanjeSestavin();
            tempSestavine.Show();
            this.Hide();
        }
    }
}
