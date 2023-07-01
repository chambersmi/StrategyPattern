using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Duck
    {
        public IFlyBehavior? flyBehavior;
        public IQuackBehavior? quackBehavior;

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior?.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior?.MakeQuack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
