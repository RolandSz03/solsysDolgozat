using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20231024
{
    class Bolygo
    {
        public string nev { get; set; }
        public int holdakszama { get; set; }
        public double bolygoterfogata { get; set; }

        public Bolygo(string s)
        {
            string[] all = s.Split(';');
            nev = all[0];
            holdakszama = int.Parse(all[1]);
            bolygoterfogata = double.Parse(all[2]);
        }
    }
}
