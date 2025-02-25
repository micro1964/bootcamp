
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        NewMethod();

        static void NewMethod()
        {
            Console.WriteLine("##################################");

            int a = 1;

            Console.WriteLine(a);

            int b = a++;

            Console.WriteLine("##################################");

            Console.WriteLine(a);

            Console.WriteLine(b);

            Console.WriteLine("##################################");

        }
    }
}