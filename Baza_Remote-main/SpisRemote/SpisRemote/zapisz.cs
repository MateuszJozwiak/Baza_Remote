using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisRemote
{
    class Save : VesselList
    {
        /// <summary>
        /// Klasa ma na celu zapisywanie zmian w wybranym wierszu statku
        /// </summary>
        /// <remarks>
        /// czysci plik tekstowy ktory jest baza danych i nadpisuje go od nowa z tym ze zaznaczony wiersz pobiera dany z WinForm
        private int indeks;
        public Save(string statek, string zadanie, int numer, DateTime data, string notatki, int indeks) : base (statek, zadanie, numer, data, notatki)
        {
            var NewShip = new Read();
            VesselList[] ZbiorStatkow = NewShip.wczytywacz();
            File.WriteAllText(BaseAddress.AddresPulpit, "");
            for (int i = 0; i < ZbiorStatkow.Length; i++)
            {

                if (i == indeks)
                    File.AppendAllText(BaseAddress.AddresPulpit, $"\n{statek};{zadanie};{Convert.ToInt32(numer)};{Convert.ToDateTime(data)};{notatki}");
                else
                    File.AppendAllText(BaseAddress.AddresPulpit, $"\n{ZbiorStatkow[i].Statek};{ZbiorStatkow[i].Zadanie};{Convert.ToString(ZbiorStatkow[i].Numer)};{Convert.ToString(ZbiorStatkow[i].Data)};{ZbiorStatkow[i].Notatki}");
            }
        }
    }
}
