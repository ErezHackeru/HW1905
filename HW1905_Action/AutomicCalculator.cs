using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1905_Action
{
    class AutomicCalculator : IAutomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoise { get; set; }
        public Func<int, int, int, double> Calculate { get; set; }
        public Action<double> ResultPrint { get; set; }

        public void Run()
        {
            int numberX = 0,numberY=0;
            int UserChoise = 0;
            double result = 0D;
            if (GetNumberFromUser!=null)
            {
                numberX = GetNumberFromUser.Invoke();
                numberY = GetNumberFromUser.Invoke();
            }
                
            if (MenuPrinter != null)
            {
                MenuPrinter.Invoke();
            }

            if (GetUserChoise != null)
            {
                UserChoise = GetUserChoise.Invoke();
            }
            if (Calculate != null)
            {
                result = Calculate.Invoke(numberX,numberY,UserChoise);
            }
            if (ResultPrint != null)
            {
                ResultPrint.Invoke(result);

            }
        }
    }
}
