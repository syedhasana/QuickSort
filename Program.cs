using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class Program
    {
        public List<int> QuickSort(List<int> array)
        {
            if (array.Count <= 1)
                return array;
            int pivotIndex = array.Count / 2;
            int pivot = array[pivotIndex];
            array.RemoveAt(pivotIndex);
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            for (int i = 0; i < array.Count; i++ )
            {
                if (array[i] <= pivot)
                {
                    less.Add(array[i]);
                }
                else
                {
                    greater.Add(array[i]);
                }
            }
            List<int> less1 = QuickSort(less);
            List<int> greater1 = QuickSort(greater);
            List<int> Final = new List<int>(less1);
            Final.Add(pivot);
            Final.AddRange(greater1);
            return Final;
        }

        static void Main(string[] args)
        {
            Program prg = new Program();
            int[] randomNumbers = new int[20];
            Random r = new Random();
            for(int i=0; i < randomNumbers.Length; i++)
                randomNumbers[i] = r.Next(10, 1000);
            Console.WriteLine("Unsorted array: {0}", string.Join(",", randomNumbers));        

            int [] num2 = prg.QuickSort(randomNumbers.ToList()).ToArray();
            Console.WriteLine("Sorted array: {0}", string.Join(",", num2));        
        }
    }
}
