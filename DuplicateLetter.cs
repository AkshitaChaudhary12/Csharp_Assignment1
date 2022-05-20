using System;

namespace Csharp
{
    internal class DuplicateLetter
    {
        static void Main(string [] args)
        {
            Console.WriteLine("please Enter your Word");
            string value=Console.ReadLine().ToUpper();
            // g occured 2 times
            //o occured 2 times
            int counter = 0;
            string isLetterExist = string.Empty;
            for(int i=0;i<value.Length;i++)
            {
               // if(!isLetterExist.Contains value(i))
                {
                    for(int j=0;j<value.Length;j++)
                    {
                        if(value[i]==value[j])
                        {
                            counter++;
                        }
                    }





                }
                if(counter>1)
                {
                    Console.WriteLine(value[i]+"has ocuured "+counter+"times");
                    isLetterExist += value[i];
                }
                counter = 0;

            }






        }







    }
}
