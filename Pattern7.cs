using System;
namespace Csharp.PatternProgram
{class Pattern_7
    {
        static void Main()
        {

            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
