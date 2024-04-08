using System;

public class Game
{
    private int _secretNumber;
    private readonly Random _random;

    public Game()
    {
        _random = new Random();
        _secretNumber = _random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
    }

    public void Play()
    {
        Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
        Console.WriteLine("Intenta adivinar un número entre 1 y 100.");

        int guess = 0;
        bool correctGuess = false;

        while (!correctGuess)
        {
            Console.Write("Introduce tu intento: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                if (guess == _secretNumber)
                {
                    Console.WriteLine("¡Felicidades! ¡Has adivinado el número secreto!");
                    correctGuess = true;
                }
                else if (guess < _secretNumber)
                {
                    Console.WriteLine("El número secreto es mayor que tu intento.");
                }
                else
                {
                    Console.WriteLine("El número secreto es menor que tu intento.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }
}
