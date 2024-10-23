using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ExtensionMethodsExample
{
    public static class Extensions
    {
        public static void GetYear(this BaseClass baseClass, int year)
        {
            Console.WriteLine(year.ToString());
        }
    }
}
