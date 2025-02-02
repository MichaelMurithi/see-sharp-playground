﻿using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string  noNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));

            if (noNullOperation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical operator is not supported.");
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}

