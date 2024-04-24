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

    public abstract void MakeGuess();

    public List<int> GetPredictions()
    {
        return Predictions;
    }
}
