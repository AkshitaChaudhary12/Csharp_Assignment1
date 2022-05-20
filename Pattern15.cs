using System;


namespace Csharp.PatternProgram
{
    internal class Pattern15
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);

                }

                Console.ReadLine();
            }
        }
    }
}
