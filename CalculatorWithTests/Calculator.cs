using System;


namespace CalculatorWithTests
{
    public class Calculator
    {
        public int? Add(int? value1, int? value2)
        {
           return value1 + value2;
        }

        public int? Subtract(int? value1, int? value2)
        {
            return value1 - value2;
        }

        public int? Multiply(int? value1, int? value2)
        {
            return value1 * value2;
        }

        public int? Divide(int? value1, int? value2)
        {
            return value1 / value2;
        }

        public int Factorial(int value1)
        {

            if (value1 <= 1)
            {
                return 1;
            }
            else
            {

                return value1 * Factorial(value1 - 1);

            }

        }
    }
}
