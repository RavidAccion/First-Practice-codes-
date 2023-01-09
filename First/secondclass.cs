using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public  class secondclass : third

    {
        public override void hide1()
        {
            Console.WriteLine("created to inherit abstarct cass");
        }
        /*<ethod overriding
         * for runing the same class in base class 
         * we want to add virtual here(base class) and override
         * in child class method*/
        public virtual void One()
        {
            Console.WriteLine("Poly Over Ride");
        }
        public void methone()
        {
            Console.WriteLine("This is my first");
        }
        public void methtwo()
        {
            Console.WriteLine("This is my second");
        }
        public void meththree()
        {
            Console.WriteLine("This is my third");
        }
    }
}
