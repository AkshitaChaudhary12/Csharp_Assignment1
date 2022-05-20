using System;


namespace PatternProgram
{
    internal class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);

                }

                Console.ReadLine();
            }
        }
    }
}
