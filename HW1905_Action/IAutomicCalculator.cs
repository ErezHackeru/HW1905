using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1905_Action
{
    interface IAutomicCalculator
    {
        int X { get; }
        int Y { get; }

        Func<int> GetNumberFromUser { get; set; }
        Action MenuPrinter { get; set; }
        Func<int> GetUserChoise { get; set; }
        Func<int,int,int,double> Calculate { get; set; }
        Action<double> ResultPrint { get; set; }
        void Run();
    }
}
