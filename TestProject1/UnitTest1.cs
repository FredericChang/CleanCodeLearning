using NUnit.Framework;
using CleanCodeLearning;

namespace TestProject1
{
    //public class Tests
    //{
    //    [SetUp]
    //    public void Setup()
    //    {
    //    }


    //    [Test]
    //    public void Test1()
    //    {
    //        Assert.Pass();
    //    }
    //}
    [TestFixture]
    public class FrameTest
    {
        [Test]
        public void TestScoreNoThrows()
        {
            Frame f = new Frame();
            f.Add(5);
            Assert.AreEqual(5, f.Score);
        }
    }
    [TestFixture]
    public class GameTest
    {
        private Game game;
        [SetUp]
        public void SetUp()
        {
            game = new Game();
        }
        [Test]
        public void TestOneThrow()
        {
            game.Add(5);
            Assert.AreEqual(5, game.Score);
        }
        [Test]
        public void TestSecondThrow()
        {
            game.Add(5);
            game.Add(4);
            Assert.AreEqual(9, game.Score);
        }
        //[Test]
        //public void TestScoreNoThrows()
        //{
        //    Game f = new Game();
        //    f.Add(5);
        //    Assert.AreEqual(5, f.Score);
        //    f.Add(4);
        //    Assert.AreEqual(9, f.Score);
        //    f.Add(7);
        //    f.Add(2);
        //    Assert.AreEqual(18, f.Score);
        //    Assert.AreEqual(9, f.ScoreForFrame(1));
        //    Assert.AreEqual(18, f.ScoreForFrame(2));

        //}
    }
}