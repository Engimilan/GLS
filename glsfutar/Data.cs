using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glsfutar
{
    internal class Data
    {
        public DateTime Datum { get; set; }
        public string Nev { get; set; }
        public int km { get; set; } 
        public int csomag { get; set; }
        public int fogy { get; set; }

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
