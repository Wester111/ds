using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Math.Pow(x,2));
            int y = 7 * a + 3 * x + 6;

            Console.WriteLine(y);


        }
    }
}
