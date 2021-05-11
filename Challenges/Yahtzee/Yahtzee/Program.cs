using System;
using System.Threading;

namespace Yahtzee
{
    public class TestClass
    {
        public Action<string> Action;
        //public static readonly String DateTime = DateTimeOffset.Now.ToString();
        //static TestClass()
        //{
        //    Console.WriteLine("TestClass static const");
        //}

        //public sealed override void Test()
        //{

        //}

        //public TestClass(){}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTimeOffset.Now);
            var tc = new TestClass();
            tc.Action = (text) => Console.WriteLine(text);
            tc.Action("Test");


            Console.WriteLine("Hello World!");
        }
    }
}
