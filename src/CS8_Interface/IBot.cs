using System;

namespace CS8_Interface
{
    public interface IBot
    {
        public string Toot() => IBot.DefaultToot();
        protected static string DefaultToot() => "デフォルトのtootです。";
//        public string Toot() => DefaultToot(this);
//        protected static string DefaultToot(IBot bot) => "デフォルトのtootです。";
//        public string Toot() => IBot::DefaultToot(); // error CS0432: エイリアス 'IBot' が見つかりません。
//        protected static string DefaultToot() => "デフォルトのtootです。";
    }
}
