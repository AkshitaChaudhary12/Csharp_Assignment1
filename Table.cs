using System;


namespace Csharp
{
    internal class Table
    {
        static void Main(string [] args)
        {
            int num;
            Console.WriteLine("enter the value of num:");
            num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine(num+"*"+i+"="+num*i);
                i++;



            }
            Console.ReadLine();

        }
    }
}
