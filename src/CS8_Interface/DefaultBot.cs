using System;

namespace CS8_Interface
{
//    public class DefaultBot : IBot {}
    public class DefaultBot : IBot
    {
        public string Toot() => IBot.DefaultToot();
    }
}
