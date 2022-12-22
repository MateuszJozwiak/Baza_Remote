using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisRemote
{
    class Read
    {
        internal VesselList[] wczytywacz()
        {
            try
            {
                List<VesselList> dane = new List<VesselList>();
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
                        var statek = new VesselList(porcjaBazaDanych[0], porcjaBazaDanych[1], Convert.ToInt32(porcjaBazaDanych[2]), Convert.ToDateTime(porcjaBazaDanych[3]), porcjaBazaDanych[4]);
                        dane.Add(statek);
                    }
                }
                return dane.ToArray();
            }
            catch 
            {
                MessageBox.Show("Brak bazy danych");
                return null;
            }
        }

    }
}
