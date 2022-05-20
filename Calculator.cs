using System;
namespace Csharp
{internal class Calculator
    { static void Main(string[] args)
        {
          int choice;
          int num1, num2;

            Console.WriteLine("*******Calculator*******");
            Console.WriteLine("enter value of num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of num1");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press 1 for Add");
            Console.WriteLine("Press 2 for Subtract");
            Console.WriteLine("Press 3 for Multiply");
            Console.WriteLine("Press 4 for Division \n");
            Console.WriteLine("Enter your choice to Start:");
            choice = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (choice)
            {
                case 1:
                    {
                        result = Add(num1 ,num2);
                        break;
                    }
                case 2:
                    {
                        result = Subtract(num1, num2);
                        break;
                    }
                case 3:
                    {
                        result = Multiply(num1 , num2);
                        break;
                    }
                case 4:
                    {
                        result = Division(num1 , num2);
                        break;
                    }
                default:

                    Console.WriteLine("Wrong achoice ! try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();

        }
            public static int Add(int num1,int num2)
            {
                int result = num1 + num2;
                return result;
            }
            public static int Subtract(int num1,int num2)
            {
                int result = num1 - num2;
                return result;


            }
              public static int Multiply(int num1,int num2)
            {
                int result = num1 * num2;
                return result;
            }
        public static int Division(int num1,int num2)
        {
            int result=num1 / num2;
            return result;
        }




            










        }
    }
