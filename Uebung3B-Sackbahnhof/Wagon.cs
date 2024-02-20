using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung3B_Sackbahnhof
{
    public class Wagon
    {
        public string Zielbahnhof { get; set; }

        public Wagon(string ziehlbahnhof) 
        {
            Zielbahnhof = ziehlbahnhof;
        }

        public override string ToString()
        {
            return Zielbahnhof;
        }
    }
}
