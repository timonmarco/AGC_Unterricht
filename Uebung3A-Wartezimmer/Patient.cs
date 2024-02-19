using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uebung3A_Wartezimmer
{
    public class Patient
    {
        private string _name;

        public Patient(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public override string ToString()
        {
            return $"Patient: {_name}";
        }
    }

}
