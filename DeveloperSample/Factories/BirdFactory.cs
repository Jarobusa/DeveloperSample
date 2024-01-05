using DeveloperSample.Enums;
using DeveloperSample.Models;

namespace DeveloperSample.Factories;

public class BirdFactory
{
    public static Swallow GetSwallow(BirdType swallowType) => new(swallowType);
}