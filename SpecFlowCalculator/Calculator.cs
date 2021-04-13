using System;
using System.Collections.Generic;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }


        public int AddTwoNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public int SubstractTwoNumbers()
        {
            return FirstNumber - SecondNumber;
        }

        public int MultiplyTwoNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public int DivideTwoNumbers()
        {
            if (SecondNumber != 0)
            {
                return FirstNumber / SecondNumber;
            }
            else
            {
                return 0;
            }
        }

        public int Add(List<int> inputNumbers)
        {
            int result = 0;
            foreach (int number in inputNumbers)
            {
                result = result + number;
            }
            return result;
        }

        public int Substract(List<int> inputNumbers)
        {
            int result = 1;
            bool firstStep = true;
            foreach (int number in inputNumbers)
            {
                if(firstStep == true)
                {
                    result = number;
                    firstStep = false;
                }
                else
                {
                    result = result - number;
                }
            }
            return result;
        }

        public int Multiply(List<int> inputNumbers)
        {
            int result = 1;
            foreach (int number in inputNumbers)
            {
                result = result * number;
            }
            return result;
        }

        public int Divide(List<int> inputNumbers)
        {
            int result = 1;
            foreach (int number in inputNumbers)
            {
                if(number != 0 && result != 0)
                {
                    if (result == 1)
                    {
                        result = number / result;
                    }
                    else
                    {
                        result = result / number;
                    }
                    
                }
                else
                {
                    return 0;
                }
            }
            return result;
        }
    }
}