using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpisRemote
{
    class Wczytaj
    {
        internal ListaStatkow[] wczytywacz()
        {
        List<ListaStatkow> dane = new List<ListaStatkow>();
        string[] BazaDanych = File.ReadAllLines(BaseAddress.AddresPulpit);
                foreach (string LinijkaWBazie in BazaDanych)
                {
                    if (String.IsNullOrEmpty(LinijkaWBazie))
                    {
                        continue;
                    }
                    else
                    {
                     string[] porcjaBazaDanych = LinijkaWBazie.Split(';');
                     ListaStatkow statek = new ListaStatkow(porcjaBazaDanych[0], porcjaBazaDanych[1], Convert.ToInt32(porcjaBazaDanych[2]), Convert.ToDateTime(porcjaBazaDanych[3]), porcjaBazaDanych[4]);
                     dane.Add(statek);
                    }
                }
                return dane.ToArray();
        }
    }
}
