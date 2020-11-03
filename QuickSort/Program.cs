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
            //for (int i = 0; i < values.Length; i++)
            //{
            //    var midElement = values.Length / 2;

            //    if(values[i] < midElement)

            //}
            if(start >= end)
            {
                return;
            }

            var a = values.Skip(start).Take(end - start + 1).ToArray();

            var pivot = values[end];
            int j = start;
            for(int i = start; i < end; i++)
            {
                if(values[i] < pivot)
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

            var b = values.Skip(start).Take(end - start + 1).ToArray();
            QuickSort(values, start, j - 1);
            QuickSort(values, j + 1, end);
        }
    }
}
