using System;


namespace Csharp
{
    internal class Lcm
    {
        static void Main(string [] args)
        {
            int num1, num2, x, y, lcm = 0;
            Console.WriteLine("enter the first number:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            num2=Convert.ToInt32(Console.ReadLine());
            x = num1;
            y = num2;
            while(num1!=num2)
            {
                if(num1>num2)
                {
                    num1 = num2 - num1;
                }
                else
                    num2 = num2 - num1;
            }
            lcm = (x * y) / num1;
            Console.WriteLine("LCM is:"+lcm);
            Console.Read();



        }
    }
}
