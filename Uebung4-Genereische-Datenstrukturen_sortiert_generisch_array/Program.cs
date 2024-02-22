namespace Uebung4_Genereische_Datenstrukturen_sortiert_generisch_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortiertesArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int gesuchterWert = 10;

            int index = BinarySearchHelfer.BinarySearch(sortiertesArray, gesuchterWert);

            if (index != -1)
            {
                Console.WriteLine($"Der Wert {gesuchterWert} wurde an der Position {index} gefunden.");
            } 
            else
            {
                Console.WriteLine($"Der Wert {gesuchterWert} wurde nicht im Array gefunden.");
            }
        }
    }
}