using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;

            int[] arr = new int[n];

            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 101);
            }

            Console.WriteLine("Array before sort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Array after sort: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        static void QuickSort(int[] array, int start, int end)
        {
            int tmp;
            int left = start;
            int right = end;
            int middle = array[(start + end) / 2];
            while (left <= right)
            {
                while (array[left] < middle)
                {
                    left++;
                }
                while (array[right] > middle)
                {
                    right--;
                }
                if (left <= right)
                {
                    tmp = array[left];
                    array[left] = array[right];
                    array[right] = tmp;
                    left++;
                    right--;
                }
            }
            if ((right - start) > 0)
            {
                QuickSort(array, start, right);
            }
            if ((end - left) > 0)
            {
                QuickSort(array, left, end);
            }
        }
    }
}
