using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glsfutar
{
    internal class Data
    {
        public DateTime Datum { get; }
        public string Nev { get;  }
        public int km { get;  } 
        public int csomag { get;  }
        public int fogy { get; }

        public Data(string sor)
        {
            string[] darabol = sor.Split(';');
            Datum = Convert.ToDateTime(darabol[0]);
            Nev= darabol[1];
            km = Convert.ToInt32(darabol[2]);
            csomag = Convert.ToInt32(darabol[3]);
            fogy = Convert.ToInt32(darabol[4]);
        }
    }
}
