using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Reflection;
namespace TEST;


[TestClass]
public class UnitTest1
{
    [TestMethod]
public void RandomNumberGenerator()
{
    // Arrange
    string playerName = "Player";
    string aiPlayerName = "AI";
    Game game = new Game(playerName, aiPlayerName);

    // Act
    int randomNumber = game.SecretNumber;

    // Assert
    Assert.IsTrue(randomNumber >= 0 && randomNumber <= 100);
}

[TestMethod]
        public void PlayerConstructor_NameInitializedCorrectly()
        {
            // Arrange
            string playerName = "Cata";

            // Act
            Player humanPlayer = new HumanPlayer(playerName);

            // Assert
            Assert.AreEqual(playerName, humanPlayer.Name);
        }

        [TestMethod]
        public void HumanPlayer_MakeGuess_ValidInput()
        {
            // Arrange
            string playerName = "Player";
            int expectedGuess = 77; //

            // Simula la entrada de usuario utilizando un StringReader mock
            using (var stringReader = new StringReader(expectedGuess.ToString()))
            {
                Console.SetIn(stringReader);

                // Act
                HumanPlayer humanPlayer = new HumanPlayer(playerName);
                humanPlayer.MakeGuess();

                // Assert
                Assert.AreEqual(expectedGuess, humanPlayer.GetPredictions()[0]); // Suponiendo que la lista de predicciones solo contiene la adivinanza actual
            }
        }

        [TestMethod]
        public void AIPlayer_MakeGuess()
        {
            // Arrange
            string aiPlayerName = "AI";
            AIPlayer aiPlayer = new AIPlayer(aiPlayerName);

            // Act
            aiPlayer.MakeGuess();

            // Assert
            Assert.IsTrue(aiPlayer.GetPredictions().Count > 0); // Verifica que  IA haya realizado una adivinanza
            Assert.IsTrue(aiPlayer.GetPredictions()[0] >= 1 && aiPlayer.GetPredictions()[0] <= 100); //adivinanza esté dentro del rango correcto
        }
    
}