using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung3A_Wartezimmer
{
    public class Wartezimmer
    {
        private Queue<Patient> _patienten;

        public Wartezimmer()
        {
            _patienten = new Queue<Patient>();
        }

        public void PatientAnmelden(Patient patient)
        {
            _patienten.Enqueue(patient);
        }

        public Patient NaechstenPatientenAufrufen()
        {
            return _patienten.Dequeue();
        }

        public bool IstLeer()
        {
            return _patienten.Count == 0;
        }

        public int AnzahlPatienten()
        {
            return _patienten.Count;
        }

        public override string ToString()
        {
            string wartezimmerText = "Wartezimmer:\n";
            foreach (Patient patient in _patienten)
            {
                wartezimmerText += patient.ToString() + "\n";
            }
            return wartezimmerText;
        }
    }
}
