using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisRemote
{
    class NewVessel
    {
        public NewVessel()
        {
            DateTime now = DateTime.Now;
            System.IO.File.AppendAllText(BaseAddress.AddresPulpit, $"\n__;__;0000;{now};wypelnij mnie");
        }
    }
}
