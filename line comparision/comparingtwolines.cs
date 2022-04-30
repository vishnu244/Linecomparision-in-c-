using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_comparision
{
    public class comparingtwolines
    {
        public void EqualtoMethod(double finalResult, double finalResult2)
        {          
            bool status = finalResult.Equals(finalResult2);
            if (status)

                Console.WriteLine("{0} is equal to {1}", finalResult, finalResult2);

            else
                Console.WriteLine("{0} is not equal to {1}", finalResult, finalResult2);

        }
    }
}
