using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung3B_Sackbahnhof
{
    public class Sackbahnhof
    {
        private Stack<Wagon> _gleisS1;
        private Stack<Wagon> _gleisS2;
        private Stack<Wagon> _gleisS3;

        public Sackbahnhof()
        {
            _gleisS1 = new Stack<Wagon>();
            _gleisS2 = new Stack<Wagon>();
            _gleisS3 = new Stack<Wagon>();
        }

        public void Umordnen()
        {
            while (_gleisS2.Count > 0)
            {
                _gleisS1.Push(_gleisS2.Pop());
            }
            while (_gleisS3.Count > 0)
            {
                _gleisS1.Push(_gleisS3.Pop());
            }

            Stack<Wagon> temp = new Stack<Wagon>();
            while (_gleisS1.Count > 0)
            {
                Wagon wagon = _gleisS1.Pop();
                if (wagon.Zielbahnhof == "A")
                {
                    temp.Push(wagon);
                }
                else
                {
                    _gleisS2.Push(wagon);
                }
            }

            while (temp.Count > 0)
            {
                _gleisS1.Push(temp.Pop());
            }
        }

        public void WagonHinzufügen(Wagon wagon, string gleis)
        {
            if (gleis == "S1")
            {
                _gleisS1.Push(wagon);
            }
            else if (gleis == "S2")
            {
                _gleisS2.Push(wagon);
            }
            else if (gleis == "S3")
            {
                _gleisS3.Push(wagon);
            }
            else
            {
                throw new ArgumentException("Ungültiges Gleis: " + gleis);
            }
        }

        public void PrintGleise()
        {
            Console.WriteLine("Gleis S1:");
            foreach (Wagon wagon in _gleisS1)
            {
                Console.WriteLine(wagon);
            }

            Console.WriteLine("Gleis S2:");
            foreach (Wagon wagon in _gleisS2)
            {
                Console.WriteLine(wagon);
            }

            Console.WriteLine("Gleis S3:");
            foreach (Wagon wagon in _gleisS3)
            {
                Console.WriteLine(wagon);
            }
        }
    }

}
