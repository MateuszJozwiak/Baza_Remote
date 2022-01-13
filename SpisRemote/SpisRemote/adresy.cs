using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisRemote
{
    class adresy
    {/// <summary>
    /// Klasa w ktorej skladowany jest adres globalny skad jest baza danych.
    /// </summary>
        private static string adres;
        public static string Adres
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }
    }
}
