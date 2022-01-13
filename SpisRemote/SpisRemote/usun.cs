using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpisRemote
{
    class usun
    {
        public int indeks;
        public string adres;
        public usun(int indeks)
        {
            this.indeks = indeks;
            adres = adresy.Adres;
        }
        public void usuwacz()
        {
            wczytaj nowy = new wczytaj();
            ListaStatkow[] po = nowy.wczytywacz();
            File.WriteAllText(adres, "");
            for (int i = 0; i < po.Length; i++)
            {

                if (i == indeks)
                    continue;
                else
                    System.IO.File.AppendAllText(adres, $"{po[i].statek};{po[i].zadanie};{Convert.ToString(po[i].numer)};{Convert.ToString(po[i].data)};{po[i].notatki}|");
            }
        }
    }
}
