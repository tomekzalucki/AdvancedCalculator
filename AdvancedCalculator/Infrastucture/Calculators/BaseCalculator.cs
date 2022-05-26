using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.Infrastucture.Calculators
{
    public class BaseCalculator
    {
        public int Addition(int number1, int number2) => number1 + number2;
        public int Subtraction(int number1, int number2) => number1 - number2;
        public int Multiplication(int number1, int number2) => number1 * number2;
        public int Division(int number1, int number2) => number1 / number2;

    }
}
