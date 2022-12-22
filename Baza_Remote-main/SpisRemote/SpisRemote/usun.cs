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
        private int indeks;
        public usun(int indeks)
        {
            this.indeks = indeks;
        }
        public void usuwacz()
        {
            var NewShip = new Read();
            VesselList[] po = NewShip.wczytywacz();
            File.WriteAllText(BaseAddress.AddresPulpit, "");
            for (int i = 0; i < po.Length; i++)
            {

                if (i == indeks)
                    continue;
                else
                    System.IO.File.AppendAllText(BaseAddress.AddresPulpit, $"\n{po[i].Statek};{po[i].Zadanie};{Convert.ToString(po[i].Numer)};{Convert.ToString(po[i].Data)};{po[i].Notatki}");
            }
        }
    }
}
