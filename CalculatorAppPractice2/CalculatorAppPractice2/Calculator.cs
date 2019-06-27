using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calculator
    {
        public int firstNumber;
        public int secondNumber;

        public int Add()
        {
            return firstNumber + secondNumber;
        }

        public int Subtract()
        {
            return firstNumber - secondNumber;
        }

        public int Multiply()
        {
            return firstNumber * secondNumber;
        }

        public int Divide()
        {
            return firstNumber / secondNumber;
        }
    }
}
