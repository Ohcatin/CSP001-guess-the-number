using System;

public class Game
{
    private readonly Player _player;
    private readonly int _secretNumber;
    private bool _correctGuess;

    public Game(Player player)
    {
        _player = player;
        _secretNumber = new Random().Next(1, 101); // Genera un número aleatorio entre 1 y 100
        _correctGuess = false;
    }

    public void Play()
    {
        Console.WriteLine($"¡Bienvenido al juego de adivinar el número, {_player.Name}!");
        Console.WriteLine("Intenta adivinar un número entre 1 y 100.");

        while (!_correctGuess)
        {
            _player.MakeGuess(); // Solicitar al jugador que haga un intento

            if (_player.LastGuess == _secretNumber)
            {
                Console.WriteLine("¡Felicidades! ¡Has adivinado el número secreto!");
                _correctGuess = true;
            }
            else if (_player.LastGuess < _secretNumber)
            {
                Console.WriteLine("El número secreto es mayor que tu intento.");
            }
            else
            {
                Console.WriteLine("El número secreto es menor que tu intento.");
            }
        }
    }
}
