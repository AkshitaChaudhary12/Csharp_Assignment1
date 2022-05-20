using System;
    namespace Csharp {

    internal class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, temp = 0;
            Console.WriteLine("enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num != 0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if (sum == temp)
                Console.WriteLine("armstrong number");
            else
                Console.WriteLine("not armstrong");
            Console.ReadKey();



        }

    }




}
