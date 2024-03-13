namespace Multiplikationsquiz
{
    class Quiz
    {
        private int factor1;
        private int factor2;
        private Random rn;

        public string Frage
        {
            get
            {
                return $"{factor1} x {factor2} = ?";
            }
        }

        public int Answer
        {
            get
            {
                return factor1 * factor2;
            }
        }

        public Quiz()
        {
            rn = new Random();
        }

        public void Next()
        {
            factor1 = rn.Next(1, 21);
            factor2 = rn.Next(1, 21);
        }

    }
}
