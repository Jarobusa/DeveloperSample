using DeveloperSample.Enums;
using DeveloperSample.Models;

namespace DeveloperSample.Factories;

public class BirdFactory
{
    public static Bird GetBird(BirdType birdType) => new(birdType);
}