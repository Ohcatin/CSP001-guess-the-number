using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Por favor, ingresa tu nombre: ");
        Console.ResetColor();
        string? playerName = Console.ReadLine() ?? ""; // Usar coalescencia nula para evitar valores nulos

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Por favor, ingresa el nombre de la IA: ");
        Console.ResetColor();
        string? AIPlayerName = Console.ReadLine() ?? ""; // Usar coalescencia nula para evitar valores nulos

        Player player = new HumanPlayer(playerName);
        Game game = new Game(playerName, AIPlayerName);
        game.Start();
    }
}
