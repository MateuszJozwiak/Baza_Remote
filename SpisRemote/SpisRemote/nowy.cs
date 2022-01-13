using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisRemote
{
    class nowy
    {
        public string adres;
        public nowy(string adres)
        {
            this.adres = adres;
            DateTime now = DateTime.Now;
            System.IO.File.AppendAllText(adres,$"__;__;0000;{now};wypelnij mnie|");
        }
    }
}
