using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class firstclass
    {
        int sum = 0;
        public void One()
        {
            Console.WriteLine("This is my first class");
        }
        public void Two(int a ,int b)
        {
            sum=a+b;
            Console.WriteLine("The sum of the number is =" + sum);
        }
    }
}
