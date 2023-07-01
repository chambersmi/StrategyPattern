namespace ConsoleUI
{
    public class MallardDuck : Duck
    {
        
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck!");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void MakeQuack()
        {
            throw new NotImplementedException();
        }
    }
}