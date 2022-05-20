using System;


namespace Csharp
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("enter first number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("n1=" + n1 + "\n n2=" + n2);
            Console.ReadKey();





        }

    }
}
