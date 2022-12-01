using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public void Check(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % 1 == 0)
                {
                    sum += i;
                }
            }
            if (num == sum)
                Console.WriteLine("Number provided is a Perfect Number");
            else
                Console.WriteLine("Not a perfect Number");
        }
    }
}
