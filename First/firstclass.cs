using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{


   /* here i have inherited the second classs with first class*/
    public class firstclass : secondclass
    {
        int sum = 0;
/* polymorphism-Method overriding
 * here we have added override to not consider the class in that class*/
        public override void One()
        {
            base.One();//to run the method in base class
            Console.WriteLine("This is my first poly override  class");
        }
        /*       Polymorphism  (method overloading) here i have used the same method 
 *       with diff no of params, so that it wont throws error.
 this is known as method overloading*/
        public void Two(int a ,int b)
        {
            sum=a+b;
            Console.WriteLine("The sum of the number is =" + sum);
        }

      
       
        public void Two(int a, int b,int c)
        {
            sum = a + b;
            Console.WriteLine("The sum of the number is =" + sum);
        }
    }
}
