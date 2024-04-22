using System;

public class HumanPlayer : Player
{
    public HumanPlayer(string name) : base(name)
    {
    }

    public override void MakeGuess()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"Hola {Name}, por favor introduce tu intento: ");
        Console.ResetColor();
        string? input = Console.ReadLine();
        int guess;

        while (!int.TryParse(input, out guess))
        {
            Console.WriteLine("Por favor, introduce un número válido.");
            Console.Write($"Hola {Name}, por favor introduce tu intento: ");
            input = Console.ReadLine();
        }

        Predictions.Add(guess);
    }
}
