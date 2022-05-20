using System;


namespace Csharp
{
    internal class DigitSum
    {
        static void Main(string [] args)
        {
            int num, r, sum = 0;
            Console.Write("Enter four digit number:");
            num=Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                r= num % 10;
                sum = sum  + r;
                num = num / 10;
            }
           Console.WriteLine("Sum of Digit are:"+sum);
            Console.ReadKey();

        }
    }
}
