using System;

namespace CS8_Interface
{
    public class GreetingBot : IBot
    {
        public string Toot() => DateTime.Now.Hour switch 
        {
            int n when (3 < n && n < 10) => "おはようございます。",
            int n when (9 < n && n < 17) => "こんにちは。",
            int _ => "こんばんは。",
        };
        /*
        public string Toot() {
//            var hour = DateTime.Now.Hour; // 0..23
//            if (hour >= 4 && 9 <= hour) { return "おはようございます。"; }
//            else if (hour >= 10 && 16 <= hour) { return "こんにちは。"; }
//            else { return "こんばんは。"; }

//            return DateTime.Now.Hour switch {
//                case int n when (3 < n && n < 10) => "おはようございます。";
//                case int n when (9 < n && n < 17) => "こんにちは。";
//                default => "こんばんは。";
//            }
            // 残念ながら以下のような範囲構文はない。
            // case 4 ... 10 => "おはよう";

//            var myswitch = new Dictionary <Func<int,bool>, Action>
//            { 
//                { x => 3 < x && x < 10, () => "おはようございます。"; },  
//                { x => 9 < x && x < 17, () => "こんにちは。"; },
//                { x => (16 < x && x < 24) && (-1 < x && x < 4),() => "こんばんは。"; },
//            };
//            return myswitch.First(sw => sw.Key(DateTime.Now.Hour)).Value();
            return null;
        }
        */
    }
}
