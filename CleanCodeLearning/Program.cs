using System;

namespace CleanCodeLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game game = new Game();
            //f.Add(5);
            //f.Add(4);
            //f.Add(7);
            //f.Add(2);

            //var a = f.ScoreForFrame(1);
            //var b = f.ScoreForFrame(2);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            game.Add(1);
            game.Add(4);
            game.Add(4);
            game.Add(5);
            game.Add(6);
            game.Add(4);
            game.Add(5);
            game.Add(5);
            game.Add(10);
            game.Add(0);
            game.Add(1);
            game.Add(7);
            game.Add(3);
            game.Add(6);
            game.Add(4);
            game.Add(10);
            game.Add(2);
            game.Add(8);
            game.Add(6);
            var a = game.Score;

        }
    }
}
