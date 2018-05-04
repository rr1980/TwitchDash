using System;
using TwitchDash.Core;

namespace Main1
{
    class Program
    {
        static void Main(string[] args)
        {
            TwitchStarter ts = new TwitchStarter();

            ts.Start();

            Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }
}
