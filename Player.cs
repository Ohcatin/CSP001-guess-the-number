using System;

public class Player
{
    public string Name { get; }
    public int LastGuess { get; private set; }

    public Player(string name)
    {
        Name = name;
        LastGuess = 0;
    }

    public void MakeGuess()
{
    Console.Write($"Hola {Name}, introduce tu intento: ");
    string input = Console.ReadLine();
    int guess;

    while (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Por favor, introduce un número ");
        Console.Write($"Hola {Name}, introduce tu intento: ");
        input = Console.ReadLine();
    }

    LastGuess = guess;
}

}
