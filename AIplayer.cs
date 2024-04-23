using System;

public class AIPlayer : Player
{
    private readonly Random _random;

    public AIPlayer(string name) : base(name)
    {
        _random = new Random();
    }

    public override void MakeGuess()
    {
        int guess = _random.Next(1, 101);
        Predictions.Add(guess);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--------------------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Name} hace una predicción: {guess}");
        Console.ResetColor();
    }
}
