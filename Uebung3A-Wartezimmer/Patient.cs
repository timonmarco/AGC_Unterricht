using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uebung3A_Wartezimmer
{
    internal class Patient
    {
        private string _name;
        public Patient(string name)    
        { 
           name = _name;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



    }
}
