using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibraryUnitTestDemoApp
{
    public class DisplayMessages
    {
        public string Greeting(string firstName, int hourOfTheDay)
        {
            string output = "";

            if (hourOfTheDay < 12)
            {
                output = $"Good morning {firstName}";
            }
            else if (hourOfTheDay < 18)
            {
                output = $"Good afternoob {firstName}";
            }
            else 
            {
                output = $"Good afternoob {firstName}";
            }
            return output;
        }
    }
}

