using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1905_Action
{
    interface ISimpleCalculator
    {
        int NumberGetter();
        void PrintMenu();
        int GetUserChoise();
        double Calculate(int x, int y, int z);
        void PrintResultNicely(double result);
    }
}
