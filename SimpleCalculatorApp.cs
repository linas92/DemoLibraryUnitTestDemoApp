using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibraryUnitTestDemoApp
{
    public class SimpleCalculatorApp
    {
        /*
        public float UserInput(float input) 
        {
            bool isNumberValid;
            float validNumber;

            string stringInput = Console.ReadLine();

            isNumberValid = float.TryParse(stringInput, out validNumber);

            return validNumber;
        }
        */

        public float Addition(float x, float y)
        {
            return x + y;
        }

        public float Subtraction(float x, float y)
        {
            return x - y;
        }

        public float Multiplication(float x, float y)
        {
            return x * y;
        }

        public float Division(float x, float y)
        {
            return x / y;
        }

    }
}

