using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek20203
{
    internal class Berek
    {
        public string nev { get; set; }
        public string neme { get; set; }
        public string reszleg { get; set; }
        public int belepes { get; set; }
        public int ber { get; set; }

        public Berek(string sor)
        {
            string[] darabok = sor.Split(";");
            nev = darabok[0];
            neme = darabok[1];
            reszleg = darabok[2];
            belepes = Convert.ToInt32(darabok[3]);
            ber = Convert.ToInt32(darabok[4]);
        }
    }
}
