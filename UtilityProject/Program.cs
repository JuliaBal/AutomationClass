using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityProject
{
    public class Utility
    {
        public static int Test(string string_string)
        {
            string_string = Console.ReadLine();
            bool isInteger = int.TryParse(string_string, out int integerValue);
            while (isInteger == false)
            {
                Console.WriteLine("You enter incorrect length");
                Console.WriteLine("Please enter integer number");
                string_string = Console.ReadLine();
                isInteger = int.TryParse(string_string, out integerValue);
            }
            return integerValue;
        }
    }
}
