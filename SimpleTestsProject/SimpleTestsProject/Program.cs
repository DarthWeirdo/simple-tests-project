using System;

namespace SimpleTestsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            i = i + 1;
            var tempr = new Temperature { C = 20};
            if (tempr.K > 0) i = 10;
            Console.WriteLine(i.ToString());
        }

        public static int Testing(int i)
        {
            return i * 10;
        }
    }
}