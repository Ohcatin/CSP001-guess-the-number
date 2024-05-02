using System;

public class AIPlayer : Player
{
    private readonly Random _random;

    public AIPlayer(string name) : base(name)
    {
        _random = new Random();
    }

    // Método para que el jugador AI haga una suposición
    public override void MakeGuess()
    {
        int guess = GenerateRandomGuess();
        Predictions.Add(guess);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--------------------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Name} hace una predicción: {guess}");
        Console.ResetColor();
    }

    // Método para generar una suposición aleatoria
    private int GenerateRandomGuess()
    {
        return _random.Next(1, 101);
    }
}
