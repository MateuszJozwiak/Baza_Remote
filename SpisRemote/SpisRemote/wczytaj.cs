using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisRemote
{
    class wczytaj
    {
        public string adres;
        public wczytaj()
        {
            adres = adresy.Adres;
        }

        public ListaStatkow[] wczytywacz()
        {
        List<ListaStatkow> dane = new List<ListaStatkow>();
            string[] dane2 = System.IO.File.ReadAllText(adres).Split('|');
        foreach(string x in dane2)
            {
                if (x=="")
                {
                    continue;
                }
                else
                {
                    string[] porcja = x.Split(';');
                    ListaStatkow statek = new ListaStatkow(porcja[0], porcja[1], Convert.ToInt32(porcja[2]), Convert.ToDateTime(porcja[3]), porcja[4]);
                    dane.Add(statek);
                }

            }
            return dane.ToArray();
    }
    }
}
