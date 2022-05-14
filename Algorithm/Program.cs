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
            while (true)
            {
                Console.WriteLine("select no\n1)insertion sort\n2)Bubble sort\n");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        String[] arr = { "India", "I", "from", "am" };
                        Console.WriteLine("unsorted string ");

                        int n = arr.Length;
                        Console.WriteLine(String.Join(" ", arr));
                        InsertionSort ob = new InsertionSort();
                        Console.WriteLine("Sorted string");
                        ob.sort(arr, n);
                        ob.printArraystring(arr, n);
                        break;
                    case 2:
                        BubbleSort ob1 = new BubbleSort();
                        int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
                        Console.WriteLine("unsorted values ");
                        ob1.printArray(arr1);
                        //Console.WriteLine(String.Join(" ", arr1));
                        ob1.bubbleSort(arr1);
                        Console.WriteLine("Sorted values");
                        ob1.printArray(arr1);
                        break;
                }
            }
        }
    }
}