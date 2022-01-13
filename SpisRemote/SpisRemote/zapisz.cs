using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisRemote
{
    class zapisz
    {
        /// <summary>
        /// Klasa ma na celu zapisywanie zmian w wybranym wierszu statku
        /// </summary>
        /// <remarks>
        /// czysci plik tekstowy ktory jest baza danych i nadpisuje go od nowa z tym ze zaznaczony wiersz pobiera dany z WinForm
        public string statek;
        public string zadanie;
        public int numer;
        public DateTime data;
        public string notatki;
        public int indeks;
        public string adres;
        public zapisz(string statek, string zadanie, int numer, DateTime data, string notatki, int indeks)
        {
            this.statek = statek;
            this.zadanie = zadanie;
            this.numer = numer;
            DateTime now = DateTime.Now;
            if (DateTime.Compare(data,now)>=0)  // usawienie daty na minimum obecna 
                this.data = data;
            else
                data = now;
            this.data = data;
            this.notatki = notatki;
            this.indeks = indeks;
            adres = adresy.Adres;
            wczytaj nowy = new wczytaj();
            ListaStatkow[] po = nowy.wczytywacz();
            File.WriteAllText(adres, "");
            for (int i = 0; i < po.Length; i++)
            {

                if (i == indeks)
                    System.IO.File.AppendAllText(adres, $"{statek};{zadanie};{Convert.ToInt32(numer)};{Convert.ToDateTime(data)};{notatki}|");
                else
                    System.IO.File.AppendAllText(adres, $"{po[i].statek};{po[i].zadanie};{Convert.ToString(po[i].numer)};{Convert.ToString(po[i].data)};{po[i].notatki}|");
            }
        }
    }
}
