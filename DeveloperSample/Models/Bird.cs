using DeveloperSample.Enums;

namespace DeveloperSample.Models;

public class Bird : IBird
{
    /// <summary>
    /// This property represents the type of bird
    /// </summary>
    public BirdType Type { get; }

    /// <summary>
    /// This property represents the load of the bird
    /// </summary>
    public BirdLoad Load { get; private set; }

    /// <summary>
    /// This constructor creates a bird
    /// </summary>
    /// <param name="birdType"></param>
    public Bird(BirdType birdType)
    {
        Type = birdType;
    }

    /// <summary>
    /// This constructor creates a bird    
    /// </summary>
    /// <param name="birdType"></param>
    /// <param name="load"></param>
    public Bird(BirdType birdType, BirdLoad load) : this(birdType)
    {
        Load = load;
    }

    /// <summary>
    /// This method applies a load to the bird
    /// </summary>
    /// <param name="load"></param>
    public void ApplyLoad(BirdLoad load)
    {
        Load = load;
    }

    /// <summary>
    /// This method returns the airspeed velocity of the bird
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public double GetAirspeedVelocity()
    {
        return Type switch
        {
            BirdType.AfricanSwallow => Load == BirdLoad.None ? 22 : 18,
            BirdType.EuropeanSwallow => (double)(Load == BirdLoad.None ? 20 : 16),
            _ => throw new InvalidOperationException(),
        };
    }
}