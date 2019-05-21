using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW1905_Action
{
    class SimpleCalculator : ISimpleCalculator
    {
        public double Calculate(int x, int y, int ChosenOption)
        {
            switch (ChosenOption)
            {
                case 1: return (x + y);
                case 2: return (x - y);
                case 3: return (x * y);
                case 4: return (x / y);
                default: return 0;                    
            }
        }

        public int GetUserChoise()
        {
            int num = 0;
            do
            {
                Console.WriteLine("==========================");
                Console.WriteLine("Please write your number:");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while ((num < 1) || (num > 4));

            return num;
        }

        public int NumberGetter()
        {
            int num = 0;
            do
            {
                Console.WriteLine("Hello , Please print a number > 0 ==>");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num <= 0);

            return num; 
        }

        public void PrintMenu()
        {
            Console.WriteLine("Here are your options to choose from:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
        }

        public void PrintResultNicely(double result)
        {
            Console.WriteLine("And the result is:");
            Thread.Sleep(1000);
            Console.WriteLine("*****************************");
            Console.WriteLine($"*********{result}*******************");
            Console.WriteLine("*****************************");                        
        }
    }
}
