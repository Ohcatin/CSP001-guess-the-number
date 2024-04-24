using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Por favor, ingresa tu nombre: ");
        Console.ResetColor();
        string? playerName = Console.ReadLine() ?? ""; 
        
        Player player = new HumanPlayer(playerName);
        Game game = new Game(playerName, "IA Player");
        game.Start();
    }
}
