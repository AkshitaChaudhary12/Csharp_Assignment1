using System;

namespace Csharp.PatternProgram
{
    class Pattern17
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 1; k <= 14; k++)
                    {
                        Console.Write(j + k);
                    }
                }

                Console.ReadLine();
            }
        }



    }
}
