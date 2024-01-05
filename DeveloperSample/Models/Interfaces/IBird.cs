using DeveloperSample.Enums;

namespace DeveloperSample;

/// <summary>
/// This interface represents a bird
/// </summary>
public interface IBird
{
    /// <summary>
    /// This property represents the type of bird
    /// </summary>
    BirdType Type { get; }

    /// <summary>
    /// This property represents the load of the bird
    /// </summary>
    BirdLoad Load { get; }

    /// <summary>
    /// This method applies a load to the bird
    /// </summary>
    /// <param name="load"></param>
    void ApplyLoad(BirdLoad load);

    /// <summary>
    /// This method returns the airspeed velocity of the bird
    /// </summary>
    /// <returns></returns>
    double GetAirspeedVelocity();
}