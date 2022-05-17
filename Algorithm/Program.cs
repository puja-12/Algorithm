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
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("select no\n1)insertion sort\n2)Bubble sort\n3)Binary Search\n4)Anagram Words\n5)Prime Numbers\n6)bubbleSort using generics\n7)binary Search using generics\n8)Merge Sort\n9)permutatuins");

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
                        ob1.bubbleSort(arr1);
                        Console.WriteLine("Sorted values");
                        ob1.printArray(arr1);
                        break;
                    case 3:
                        BinarySearch bs = new();
                        string[] arr2 = { "apple", "ball", "cat", "dog", "egg", "fish" };
                        bs.printBinarystring(arr2);
                        Console.WriteLine("Please enter a string to be searched :");
                        string key = Console.ReadLine();
                        int result = bs.binary_search_Method(arr2, key);
                        if (result == -1)
                            Console.WriteLine("Element not present");
                        else
                            Console.WriteLine("Element found at "
                                            + "index " + result);
                        Console.WriteLine(result);
                        break;
                    case 4:
                        string firstString, secondString;
                        Console.WriteLine("Enter first string");
                        firstString = Console.ReadLine();
                        Console.WriteLine("Enter second string");
                        secondString = Console.ReadLine();
                        Anagram anagram = new Anagram();
                        if (anagram.areAnagram(firstString, secondString) == true)
                        {
                            Console.WriteLine("Both string are anagram string.");
                        }
                        else
                        {
                            Console.WriteLine("Both string are not anagram string.");
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        PrimeNumber primeNumbers = new PrimeNumber();
                        primeNumbers.primeNumber();
                        break;
                    case 6:
                        BubbleSortGeneric<int> Sorter = new();
                        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
                        Console.WriteLine("unsorted values ");
                        Sorter.printArray(array);
                        Sorter.bubbleSort(array);
                        Console.WriteLine("sorted values ");
                        Sorter.printArray(array);
                        break;
                    case 7:
                        BinarySearchGenerics<string> sorter2 = new();
                        string[] array2 = { "apple", "ball", "cat", "dog", "egg", "fish" };
                        sorter2.printBinary(array2);
                        Console.WriteLine("Please enter a string to be searched :");
                        string val = Console.ReadLine();
                        int result1 = sorter2.binarySearch(array2, val);
                        if (result1 == -1)
                            Console.WriteLine("Element not present");
                        else
                            Console.WriteLine("Element found at "
                                            + "index " + result1);
                        Console.WriteLine(result1);
                        break;
                    case 8:
                        MergeSort merge = new MergeSort();

                        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
                        int len = 9;
                        Console.WriteLine("MergeSort :");
                        merge.sortmethod(numbers, 0, len - 1);
                        for (int i = 0; i < 9; i++)
                            Console.WriteLine(numbers[i]);
                        Console.Read();
                        break;
                    case 9:

                        string str = "ABC";
                        char[] charArry = str.ToCharArray();
                        permutation.Permute(charArry, 0, 2);
                        Console.ReadKey();
                        break;

                }
            }
        }

        }
    }
