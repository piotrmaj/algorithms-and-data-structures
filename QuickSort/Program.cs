using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;

namespace QuickSort
{
    class Program
    {
        private Action a;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random randNum = new Random();
            int[] test2 = Enumerable
                .Repeat(0, 50000)
                .Select(i => randNum.Next(0, 100000))
                .ToArray();

            int[] values = test2; // new int[] { 5, 3, 2, 10, 20, 6 };

            //Console.WriteLine($"[{string.Join(',', values)}]");

            //QuickSortIterative(values, 0, values.Length - 1);

            //var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

            //BenchmarkRunner.Run<Md5VsSha256>();

            Utils.Measure("QuickSortIterative", () => QuickSortIterative(values, 0, values.Length - 1));
            Utils.Measure("QuickSortRecursive", () => QuickSortRecursive(values, 0, values.Length - 1));

            //QuickSortIterative(values, 0, values.Length - 1);


            //Console.WriteLine($"[{string.Join(',', values)}]");
            Console.ReadKey();
        }

        private static void QuickSortRecursive(int[] values, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int j = Partition(values, start, end);

            QuickSortRecursive(values, start, j - 1);
            QuickSortRecursive(values, j + 1, end);
        }

        private static void QuickSortIterative(int[] values, int start, int end)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(start);
            stack.Push(end);

            while (stack.Count > 0)
            {
                var b = stack.Pop();
                var a = stack.Pop();

                int j = Partition(values, a, b);
                if (j - 1 > a)
                {
                    stack.Push(a);
                    stack.Push(j - 1);
                }

                if (j + 1 < b)
                {
                    stack.Push(j + 1);
                    stack.Push(b);
                }
            }
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

    public static class Utils
    {
        public static void Measure(string name, Action action, Action setup = null)
        {
            const int repeats = 2;
            long total = 0L;

            //
            // Warm-up by bringing the required data into the cache.
            //

            if (setup != null)
            {
                setup();
            }

            action();

            var watch = new Stopwatch();
            for (int i = 0; i < repeats; ++i)
            {
                if (setup != null)
                {
                    setup();
                }

                watch.Start();
                action();
                watch.Stop();
                total += watch.ElapsedMilliseconds;
                watch.Reset();
            }

            Console.WriteLine("{0} took about {1} ms", name, total / repeats);
        }
    }
}
