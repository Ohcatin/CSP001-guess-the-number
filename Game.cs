using System;
using System.Collections.Generic;

public class Game
{
    private Player _humanPlayer;
    private Player _AIPlayer;
    private int _secretNumber;

    public Game(string humanPlayerName, string AIPlayerName)
    {
        _humanPlayer = new HumanPlayer(humanPlayerName);
        _AIPlayer = new AIPlayer(AIPlayerName);
        _secretNumber = RandomNumberGenerator();
    }

    public void Start()
    {
        Console.WriteLine($"¡Bienvenido al juego de adivinar el número, {_humanPlayer.Name}!");
        Console.WriteLine("Intenta adivinar un número entre 1 y 100.");

        bool humanTurn = true;
        while (true)
        {
            if (humanTurn)
            {
                _humanPlayer.MakeGuess();
                if (CheckGuess(_humanPlayer))
                    break;
            }
            else
            {
                _AIPlayer.MakeGuess();
                if (CheckGuess(_AIPlayer))
                    break;
            }
            humanTurn = !humanTurn;
        }
    }

    private int RandomNumberGenerator()
    {
        Random random = new Random();
        return random.Next(1, 101);
    }

    public bool CheckGuess(Player player)
    {
        List<int> predictions = player.GetPredictions();
        int lastGuess = predictions[predictions.Count - 1];
        if (lastGuess == _secretNumber)
        {
            Console.WriteLine($"¡Felicidades {player.Name}! ¡Has adivinado el número secreto!");
            return true;
        }
        else if (lastGuess < _secretNumber)
        {
            Console.WriteLine($"El número secreto es mayor que el intento de {player.Name}.");
        }
        else
        {
            Console.WriteLine($"El número secreto es menor que el intento de {player.Name}.");
        }
        return false;
    }
}
