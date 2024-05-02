using System;

public class HumanPlayer : Player
{
    public HumanPlayer(string name) : base(name)
    {
    }

    // Método para que el jugador humano haga una suposición
    public override void MakeGuess()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--------------------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"{Name}, por favor introduce tu intento: ");
        Console.ResetColor();
        string? input = Console.ReadLine();

        // Validar la entrada del usuario
        int guess = ValidateInput(input);

        Predictions.Add(guess);
    }

    // Método para validar la entrada del usuario y convertirla a entero
    public int ValidateInput(string? input)
    {
        int guess;
        while (!int.TryParse(input, out guess))
        {
            Console.WriteLine("Por favor, introduce un número válido.");
            Console.Write($"Hola {Name}, por favor introduce tu intento: ");
            input = Console.ReadLine();
        }
        return guess;
    }
}
