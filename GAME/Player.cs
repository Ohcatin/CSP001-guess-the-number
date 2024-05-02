using System.Collections.Generic;

public abstract class Player
{
    public string Name { get; }
    protected List<int> Predictions { get; }

    protected Player(string name)
    {
        Name = name;
        Predictions = new List<int>();
    }

    // Método abstracto para hacer una suposición
    public abstract void MakeGuess();

    // Método para obtener las suposiciones realizadas por el jugador
    public List<int> GetPredictions()
    {
        return Predictions;
    }
}
