using SpisRemote.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisRemote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void WczytajB_Click(object sender, EventArgs e)
        {
            List<DateTime> spis2 = new List<DateTime>();
            ZapiszB.Enabled = true;
            UsunB.Enabled = true;
            StatkiLista.Items.Clear();
            wczytaj nowy = new wczytaj();
            ListaStatkow[] po = nowy.wczytywacz();
            foreach (ListaStatkow x in po)
                StatkiLista.Items.Add(x.statek);
            for (int i = 0; i < po.Length; i++)
                spis2.Add(po[i].data);

            rozpiska.BoldedDates = spis2.ToArray();
        }
        private void StatkiLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = (int)StatkiLista.SelectedIndex;
            if (indeks != -1)
            {
                wczytaj nowy = new wczytaj();
                ListaStatkow[] po = nowy.wczytywacz();
                NazwaS.Text = po[indeks].statek;
                ZadanieS.Text = po[indeks].zadanie;
                NumerS.Text = Convert.ToString(po[indeks].numer);
                dataS.Value = po[indeks].data;
                NotatkiS.Text = po[indeks].notatki;
                rozpiska.SetDate(po[indeks].data);
                rozpiska.BackColor = Color.Red;
                DateTime now = DateTime.Now;
                if (DateTime.Compare(po[indeks].data, now.AddDays(3)) >= 0)
                    Obrazek.Image = Resources.blue;
                else
                    Obrazek.Image = Resources.red;
            }
        }
        private void NowyB_Click(object sender, EventArgs e)
        {
            nowy wpis = new nowy(textAdres.Text);
            WczytajB.PerformClick();
        }
        private void ZapiszB_Click(object sender, EventArgs e)
        {
            zapisz nowy = new zapisz(NazwaS.Text, ZadanieS.Text, Convert.ToInt32(NumerS.Text), Convert.ToDateTime(dataS.Text), NotatkiS.Text, StatkiLista.SelectedIndex);
            WczytajB.PerformClick();
        }
        private void UsunB_Click(object sender, EventArgs e)
        {
            DialogResult potwierdz = MessageBox.Show("Czy na pewno usunac?", "Potwierdz", MessageBoxButtons.YesNo);
            if (potwierdz == DialogResult.Yes)
            {
                usun stary = new usun(StatkiLista.SelectedIndex);
                stary.usuwacz();
                WczytajB.PerformClick();
                StatkiLista.SetSelected(0, true); // ustawia indeks na pierwszy z gory
            }
        }

        private void rozpiska_DateChanged(object sender, DateRangeEventArgs e)
        {
            wczytaj nowy = new wczytaj();
            ListaStatkow[] po = nowy.wczytywacz();
        }

        private void Adres_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            adresy.Adres = openFileDialog1.FileName;
            textAdres.Text = adresy.Adres;
        }
    }
}