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
      BoardGame newGame = new BoardGame();
      
    }
  }
}
