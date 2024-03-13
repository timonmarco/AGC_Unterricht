namespace Leihfahrraeder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //testdaten
            List<Fahrrad> leihraeder = GeneriereLeihraeder();

            leihraeder.Sort();

            foreach (var item in leihraeder)
            {
                Console.WriteLine(item);
            }

            leihraeder.Sort(CompareID);

            foreach (var item in leihraeder) { Console.WriteLine(item); }

            Fahrrad f = new Fahrrad(123456, "no name", Typ.Mountainbike, 58);

            Fahrrad? ergebnis = SearchComparable(leihraeder, f);

            Console.WriteLine("=>" + ergebnis);
            Console.WriteLine(ergebnis == null);
        }

        public static T? SearchComparable<T>(List<T> list, T value) where T : IComparable<T>
        {
            foreach (var item in list)
            {
                if (item.CompareTo(value) == 0)
                {
                    return item;
                }
            }

            return default(T);
        }

        private static int CompareID(Fahrrad x, Fahrrad y)
        {
            //if (x.Id > y.Id)
            //    return 1;
            //else if (x.Id == y.Id)
            //    return 0;
            //else return -1;
            //return x.Id - y.Id;

            return x.Id.CompareTo(y.Id);
        }

        private static List<Fahrrad> GeneriereLeihraeder()
        {
            throw new NotImplementedException();
        }
    }
}
