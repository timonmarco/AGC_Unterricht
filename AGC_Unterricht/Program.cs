using System;

namespace Arztpraxis
{
    public class Patient
    {
        private string _name;

        // Konstruktor
        public Patient(string name)
        {
            _name = name;
        }

        // Eigenschaft für den Namen des Patienten
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // ToString-Methode, um eine lesbare Darstellung des Patienten zu erhalten
        public override string ToString()
        {
            return $"Patient: {_name}";
        }
    }
}
