using System;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] values = new int[] { 5, 3, 2, 10, 20, 6 };

            Console.WriteLine($"[{string.Join(',', values)}]");

            QuickSort(values, 0, values.Length - 1);

            Console.WriteLine($"[{string.Join(',', values)}]");
            Console.ReadKey();
        }

        private static void QuickSort(int[] values, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int j = Partition(values, start, end);

            QuickSort(values, start, j - 1);
            QuickSort(values, j + 1, end);
        }

        private static int Partition(int[] values, int start, int end)
        {
            var pivot = values[end];
            int j = start;
            for (int i = start; i < end; i++)
            {
                if (values[i] < pivot)
                {
                    var temp1 = values[j];
                    values[j] = values[i];
                    values[i] = temp1;
                    j++;
                }
            }
            var temp = values[j];
            values[j] = pivot;
            values[end] = temp;
            return j;
        }
    }
}
