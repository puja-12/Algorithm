// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class program
    {
        public static void Main()
        {
            String[] arr = { "India", "I", "from", "am" };
            Console.WriteLine("unsorted string ");

            int n = arr.Length;
            Console.WriteLine(String.Join(" ", arr));
            InsertionSort ob = new InsertionSort();
            Console.WriteLine("Sorted string");
            ob.sort(arr, n);
            ob.printArraystring(arr, n);
        }
    }
}