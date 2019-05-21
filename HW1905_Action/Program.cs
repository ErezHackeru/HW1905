using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1905_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            ISimpleCalculator simpleCalculator = new SimpleCalculator();
            IAutomicCalculator automicCalculator = new AutomicCalculator();

            automicCalculator.GetNumberFromUser = simpleCalculator.NumberGetter;
            automicCalculator.GetUserChoise = simpleCalculator.GetUserChoise;
            automicCalculator.MenuPrinter = simpleCalculator.PrintMenu;
            automicCalculator.ResultPrint = simpleCalculator.PrintResultNicely;
            automicCalculator.ResultPrint += (double result) => Console.WriteLine($"The result is: {result}");
            automicCalculator.Calculate = simpleCalculator.Calculate;

            automicCalculator.Run();

            Console.ReadKey();
        }
    }
}
