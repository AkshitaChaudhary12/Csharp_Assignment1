using System;


namespace Csharp
{
    internal class SquareArea
    { 
        static void Main(string [] args)
        {
            int a, area = 0;
            Console.WriteLine("Enter value of a:");
            a=Convert.ToInt32(Console.ReadLine());
            area = a * a ;
            Console.WriteLine(area);

        }

    }
}
