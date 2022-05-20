using System;

namespace Csharp
{
    internal class Maximum4
    {
        static void Main(string [] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("enter the value of num1:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of num2:");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of num3:");
            num3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of num4:");
            num4=Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1 > num4)
                Console.WriteLine("Maximum number is num1:" + num1);

            else if (num2 > num1 && num2 > num3 && num2 > num4)
                Console.WriteLine("Maximum number is num2:" + num2);

            else if (num3 > num1 && num3 > num2 && num3 > num4)
                Console.WriteLine("Maximum number is num3:" + num3);

            else
                Console.WriteLine("Maximum number is num4:" + num4);
            Console.ReadKey();



        }
            
            
            
            }

}
