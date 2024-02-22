namespace Uebung4_Generische_Datenstrukturen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] array = { 1, 3, 5, 7, 9, 12, 15, 19 };
            int value = 15;

            int index = BinarySearch(array, value);
            if (index != -1)
            {
                Console.WriteLine($"Element {value} gefunden an Index {index}");
            }
            else
            {
                Console.WriteLine($"Element {value} nicht gefunden");
            }

        }

        private static int BinarySearch(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == value)
                {
                    return mid;
                }
                else if (array[mid] > value)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
