using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisRemote
{

    class VesselList
    {
        /// <summary>
        /// Container for Datas
        /// Most of them Have only public get
        /// only Data has set because I wish not to be possible to set yestarday date.
        /// </summary>
        public string Statek { get; }
        public string Zadanie { get; }
        public int Numer { get; }
        private DateTime _data;
        public DateTime Data {
            get
            {
                return _data;
            }
            set
            {
                var now = DateTime.Now;
                if (DateTime.Compare(_data, now) >= 0)  // ustawienie daty na minimum obecna 
                    _data = value;
                else
                    _data = now;
            }
        }
        public string Notatki { get; }

        public VesselList(string statek, string zadanie, int numer, DateTime data, string notatki)
        {
            Statek = statek;
            Zadanie = zadanie;
            Numer = numer;
            _data = data;
            Notatki = notatki;
        }
    }

}
