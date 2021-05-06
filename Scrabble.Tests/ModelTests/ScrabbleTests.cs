using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class BoardGameTests
  {
    [TestMethod]
    public void BoardGameConstructor_CreatesInstanceOfGame_Game()
    {
      BoardGame newGame = new BoardGame();
      Assert.AreEqual(typeof(BoardGame), newGame.GetType());
    }

    [TestMethod]
    public void ScoreCounter_BreaksWordIntoAStringAndMatchestheValues_Int()
    {
      string testWord = "dog";
      char[] testWordArray = { 'd', 'o', 'g'};
      BoardGame newGame = new BoardGame();
      CollectionAssert.AreEqual(testWordArray, newGame.ScoreCounter(testWord));

    }
  }
}
