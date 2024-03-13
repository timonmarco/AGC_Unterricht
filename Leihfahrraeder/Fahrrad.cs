namespace Leihfahrraeder
{
    internal class Fahrrad : IComparable<Fahrrad>
    {
        private int _id;
        private string _marke;
        private Typ _typ;
        private int _rahmengroesse;

        public int Id { get => _id; set => _id = value; }
        public string Marke { get => _marke; set => _marke = value; }
        internal Typ Typ { get => _typ; set => _typ = value; }
        public int Rahmengroesse { get => _rahmengroesse; set => _rahmengroesse = value; }


        public Fahrrad(int id, string marke, Typ typ, int rahmengroesse)

        {
            Id = id;
            Marke = marke;
            Rahmengroesse = rahmengroesse;
            Typ = typ;
        }

        public override string ToString()
        {
            return $"Fahrrad";
        }

        public int CompareTo(Fahrrad? other)
        {
            if (other == null) return 1;

            if (Typ < other.Typ) //if (TypCompareTo(other.Typ)>0)
            {
                return -1;
            }
            else if (Typ == other.Typ) //else if (Typ.CompareTo(other.Typ) == 0)
            {
                //return 0;
                ///später Rahmengroesse
                return Rahmengroesse.CompareTo(other.Rahmengroesse);
            }
            else
            {
                return 1;
            }

            //return Typ.CompareTo(other.Typ);
        }


    }
}
