using System;

namespace CleanCodeLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game f = new Game();
            f.Add(5);
            f.Add(4);
            f.Add(7);
            f.Add(2);

            var a = f.ScoreForFrame(1);
            var b = f.ScoreForFrame(2);
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
