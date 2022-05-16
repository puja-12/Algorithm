using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BinarySearchGenerics<T> where T : IComparable<T>
    {


        public  int binarySearch(T[] list, T needle)
        {
            int left = 0;
            int right = list.Count() - 1;

            while (left <= right)
            {
                int median = (left + right) / 2;
                T item = list.ElementAt(median);

                var comparison = needle.CompareTo(item);
                if (comparison == 0)
                {
                    return median;
                }

                if (comparison < 0)
                {
                    right = median - 1;
                }
                else
                {
                    left = median + 1;
                }
            }

            return -1;
        }
    
    
            public void printBinary(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}


