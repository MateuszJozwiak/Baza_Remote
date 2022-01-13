using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisRemote
{

    class ListaStatkow
    {
        public string statek;
        public string zadanie;
        public int numer;
        public DateTime data;
        public string notatki;
        public ListaStatkow(string statek, string zadanie, int numer, DateTime data, string notatki)
        {
            this.statek = statek;
            this.zadanie = zadanie;
            this.numer = numer;
            this.data = data;
            this.notatki = notatki;
        }
    }

}
