using System;


namespace Csharp.PatternProgram
{
    internal class Pattern2
    {
        static void Main(string[] args)
        {
            for(char c='A';c<='E';c++)
            {
                for (char d = 'A'; d <= c; d++)
                {
                    Console.Write(d);
                }

                Console.ReadLine();

            }
        }
    }
}
