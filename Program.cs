using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
        Console.Write("Por favor, ingresa tu nombre: ");
        string playerName = Console.ReadLine();

        Player player = new Player(playerName);
        Game game = new Game(player);
        game.Play();
    }
}
