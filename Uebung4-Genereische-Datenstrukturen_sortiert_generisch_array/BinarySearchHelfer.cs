using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung4_Genereische_Datenstrukturen_sortiert_generisch_array
{

public static class BinarySearchHelfer
    {
        public static int BinarySearch<T>(T[] array, T value) where T : IComparable<T>
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int comparisonResult = array[middle].CompareTo(value);

                if (comparisonResult == 0)
                {
                    return middle; 
                }
                else if (comparisonResult < 0)
                {
                    left = middle + 1; 
                }
                else
                {
                    right = middle - 1; 
                }
            }

            return -1;
        }
    }

}
