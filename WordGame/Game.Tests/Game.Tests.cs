using NUnit.Framework;
using Game;

namespace Game.Tests {
  [TestFixture]
  public class GameTests {
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess() {
      Game game = new Game("MAKERS");
      Assert.AreEqual("B_____", game.GetWordToGuess());
    }
  }
}

// What is the type of the value on the "right" of the assertion ("B_____")? 
  // the type is a string
// What then needs to be the type returned by GetWordToGuess()?
  // the returned type needs to be a string