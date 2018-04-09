using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackBehavior = new Quack();
            this.flyBehavior = new FlyWithWings();
        }

        public void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
