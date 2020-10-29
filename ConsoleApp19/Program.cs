using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 123;
            int reversed = 0;
            int pop;

            while(x !=0)
            {
                pop = x % 10;
                x = x / 10;
                reversed = (reversed * 10) + pop;
            }
            Console.WriteLine(reversed);
            Console.ReadLine();

        }
    }
}
