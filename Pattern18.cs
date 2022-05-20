using System;


namespace Csharp.PatternProgram
{
    internal class Pattern18
    {
        static void Main(string[] args)
        {
            for (char c = 'E'; c >= 'A'; c--)
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
