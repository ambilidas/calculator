using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Calculator
    {
        public void add()
        {
            int num = 10;
            int num2 = 20;
            int sum = num + num2;
            Console.WriteLine("addition of {0} + {1} = {2}",num,num2,sum);
        }

        public void addition(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Addition of {0} + {1} = {2}", num1, num2, sum);
        }
    }
}
