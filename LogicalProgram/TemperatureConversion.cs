using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class TemperatureConversion
    {
        public void Conversion()
        {
            double F, C;
            Console.WriteLine("Enter the value of Celsius:");
            C = Convert.ToDouble(Console.ReadLine());
            F = C * 9 / 5 + 32;
            Console.WriteLine(C + "°C in Fahrenheit is: " + F + "°F");
            Console.WriteLine("Enter the value of Fahrenheit:");
            F = Convert.ToDouble(Console.ReadLine());
            C = (F - 32) * 5 / 9;
            Console.WriteLine(F + "°F in Celsius is: " + C + "°C");
        }
    }
}
