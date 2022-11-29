using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisRemote
{

    class ListaStatkow
    {
        private string _statek;
        public string Statek { get { return _statek; } set { _statek = value; } }

        private string _zadanie;
        public string Zadanie { get { return _zadanie; } set { _zadanie = value; } }

        private int _numer;
        public int Numer { get { return _numer; } set { _numer = value; } }

        private DateTime _data;
        public DateTime Data { get { return _data; } set { _data = value; } }

        private string _notatki;
        public string Notatki { get { return _notatki; } set { _notatki = value; } }

        public ListaStatkow(string statek, string zadanie, int numer, DateTime data, string notatki)
        {
            Statek = statek;
            Zadanie = zadanie;
            Numer = numer;
            Data = data;
            Notatki = notatki;
        }
    }

}
