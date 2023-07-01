namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine("---------------------------");

            Duck poorDuck = new DeadDuck();
            poorDuck.PerformQuack();
            poorDuck.PerformFly();
            
            Console.WriteLine("---------------------------");
            
            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}