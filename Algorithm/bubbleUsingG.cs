using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{

    public class BubbleSortGeneric<T> where T: IComparable<T>
    {

        public void bubbleSort(T[] array)
        {
            int n = array.Length;
            while (n > 0)
            {
                int lastModifiedIndex = 0;
                for (int i= 1; i < n; i++)
                {
                    if (array[i - 1].CompareTo(array[i]) > 0)
                    {
                     
                        T temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;                       
                        lastModifiedIndex = i;
                    }
                }

                n = lastModifiedIndex;
            }
        }

            public void printArray(T[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }
}
    

