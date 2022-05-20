using System;
namespace Csharp
{ internal class Gcd
    { static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter the value of num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            while(num1!=num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;
                else
                    num2 = num2 - num1;
            }
            Console.WriteLine("GCD is :",+num1);
            Console.ReadKey();



        }
    }
}
