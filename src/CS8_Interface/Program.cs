using System;

namespace CS8_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.WriteLine(IBot::DefaultToot()); // protectedなので参照不可(error CS0432)
//            Console.WriteLine(IBot::Toot()); // staticでないため::で参照不可(error CS0432)
//            Console.WriteLine(IBot.Toot()); // newせねば.で参照不可(error CS0120)
//            Console.WriteLine(new IBot().Toot()); // interfaceはnewできない(error CS0144)
            Console.WriteLine(new DefaultBot().Toot()); // (error CS1061)
            Console.WriteLine(new FixedBot().Toot());
            Console.WriteLine(new DateTimeBot().Toot());
            Console.WriteLine(new GreetingBot().Toot());
        }
    }
}
