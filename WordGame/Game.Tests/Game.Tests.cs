using NUnit.Framework;
using Game;

namespace Game.Tests {
  [TestFixture]
  public class GameTests {
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess() {
      Game game = new Game();
      Assert.AreEqual("B_____", game.GetWordToGuess());
    }
  }
}