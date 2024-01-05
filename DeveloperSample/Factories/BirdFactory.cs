using DeveloperSample.Enums;
using DeveloperSample.Models;

namespace DeveloperSample.Factories;

public class BirdFactory
{
    public static Bird GetSwallow(BirdType birdType) => new(birdType);
}