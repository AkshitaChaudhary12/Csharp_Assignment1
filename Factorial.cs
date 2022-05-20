using System;


namespace Csharp
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int n,i=1,fact=1;
            Console.WriteLine("enter value of n");
            n = Convert.ToInt32(Console.ReadLine());
            while(i<=n)
            {
                fact = fact * i;
                 
                
            }
            Console.WriteLine("n!="+(n)+"*"+(n - 1)+"*"+(n - 2)+ "*"+(n - 3)+ "*" +(n - 4)+"="+fact);
            Console.ReadKey();
        }

    }
}
