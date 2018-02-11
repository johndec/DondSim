using System;

namespace DondSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GameBoard gb = new GameBoard();
            Console.WriteLine("Average is {0}", gb.getAverage());
            gb.removeValue(1000000);
            Console.WriteLine("Average is {0}", gb.getAverage());
        }
    }
}
