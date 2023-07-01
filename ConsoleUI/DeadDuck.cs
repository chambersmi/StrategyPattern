using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class DeadDuck : Duck
    {
        public DeadDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Oh no!");
        }
    }
}
