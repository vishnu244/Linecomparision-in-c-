using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_comparision
{
    public class comparetomethod
    {
        public void CompareTo(double finalResult, double finalResult2)
        {           
            
            int res = finalResult.CompareTo(finalResult2);
            Console.WriteLine("Difference Between Line1 and Line2 is " + res);
            if (res == 0)
            {
                Console.WriteLine("Lengths are equal!");
            }
            else if (res > 0)
            {
                Console.WriteLine("Line 1 is greator than line 2 ");
            }
            else
            {
                Console.WriteLine("Line 2 is greator than line 1 ");
            }
        }
    }
}
