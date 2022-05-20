using System;


namespace Csharp
{
    internal class PrimeNumber
    {
        static void Main(string [] args)
        {
            int num, flag = 0;
            Console.WriteLine("enter the value of num:");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("not prime");

                    flag = 1;
                    break;
                }


            }
            if (flag == 0)
                Console.WriteLine("Prime number");
            
                //Console.WriteLine("not prime");
            Console.ReadKey();





        }





    }
}
