using SpisRemote.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisRemote
{
    public partial class Form1 : Form
    {
        private int _roznicaDni = 3;
        private string _defaultAdress = @"C:\";
        public Form1()
        {
            InitializeComponent();
        }
        private void WczytajB_Click(object sender, EventArgs e)
        {
            if (File.Exists(BaseAddress.AddresPulpit))
            {
                List<DateTime> Spis = new List<DateTime>();
                ZapiszB.Enabled = true;
                UsunB.Enabled = true;
                WczytajStatki(Spis);
            }
            else
            {
                MessageBox.Show("Brak listy statkow","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StatkiLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int indeks = (int)StatkiLista.SelectedIndex;
                if (indeks != -1)
                {
                    var NewShip = new Read();
                    VesselList[] po = NewShip.wczytywacz();
                    ListaStatkowWczytajDane(po, indeks);
                    var now = DateTime.Now;
                    PokazStatusObrazka(po, indeks, now);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void NowyB_Click(object sender, EventArgs e)
        {
            var wpis = new NewVessel();
            WczytajB.PerformClick();
        }

        private void ZapiszB_Click(object sender, EventArgs e)
        {
            if(File.Exists(BaseAddress.AddresPulpit))
            {
                var NowyStatek = new Save(NazwaS.Text, ZadanieS.Text, Convert.ToInt32(NumerS.Text), Convert.ToDateTime(dataS.Text), NotatkiS.Text, StatkiLista.SelectedIndex);
                WczytajB.PerformClick();
            }
            else
            {
                var saveFileDialogBase = new SaveFileDialog();
                saveFileDialogBase.InitialDirectory = _defaultAdress;
                saveFileDialogBase.ShowDialog();
            }

        }
        private void UsunB_Click(object sender, EventArgs e)
        {
            DialogResult potwierdz = MessageBox.Show("Czy na pewno usunac?", "Potwierdz", MessageBoxButtons.YesNo);
            if (potwierdz == DialogResult.Yes)
            {
                usun staryWpis = new usun(StatkiLista.SelectedIndex);
                staryWpis.usuwacz();
                WczytajB.PerformClick();
            }
        }

        private void rozpiska_DateChanged(object sender, DateRangeEventArgs e)
        {
            var NewShip = new Read();
            VesselList[] po = NewShip.wczytywacz();

        }
        private void ListaStatkowWczytajDane(VesselList[] input, int indeks)
        {
            NazwaS.Text = input[indeks].Statek;
            ZadanieS.Text = input[indeks].Zadanie;
            NumerS.Text = Convert.ToString(input[indeks].Numer);
            dataS.Value = input[indeks].Data;
            NotatkiS.Text = input[indeks].Notatki;
            rozpiska.SetDate(input[indeks].Data);
            rozpiska.BackColor = Color.Red;
        }
        private void PokazStatusObrazka(VesselList[] input, int indeks, DateTime czas)
        {
            if (DateTime.Compare(input[indeks].Data, czas.AddDays(_roznicaDni)) >= 0)
                Obrazek.Image = Resources.blue;
            else
                Obrazek.Image = Resources.red;
        }
        private void WczytajStatki(List<DateTime> Lista)
        {
            StatkiLista.Items.Clear();
            var NewShip = new Read();
            VesselList[] po = NewShip.wczytywacz();
            foreach (VesselList statek in po)
                StatkiLista.Items.Add(statek.Statek);
            for (int i = 0; i < po.Length; i++)
                Lista.Add(po[i].Data);
            rozpiska.BoldedDates = Lista.ToArray();
        }
    }

}