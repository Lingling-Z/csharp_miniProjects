using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLibrary
{
    public class GreetMessage
    {
        public string Greetings(int hourOfDay)
        {
            string output = string.Empty;
            if (hourOfDay < 5)
            {
                output = "Go to bed";
            }
            else if (hourOfDay < 12)
            {
                output = "Good morning";
            }
            else if (hourOfDay < 18)
            {
                output = "Good afternoon";
            }
            else
            {
                output = "Good evening";
            }
            return output;
        }
    }
}

