using DeveloperSample.Enums;
using DeveloperSample.Factories;
using Xunit;

namespace DeveloperSample.ClassRefactoring;
public class ClassRefactorTest
{
    [Fact]
    public void AfricanSwallowHasCorrectSpeed()
    {
        var bird = BirdFactory.GetBird(BirdType.AfricanSwallow);
        Assert.Equal(22, bird.GetAirspeedVelocity());
    }

    [Fact]
    public void LadenAfricanSwallowHasCorrectSpeed()
    {
        var bird = BirdFactory.GetBird(BirdType.AfricanSwallow);
        bird.ApplyLoad(BirdLoad.Coconut);
        Assert.Equal(18, bird.GetAirspeedVelocity());
    }

    [Fact]
    public void EuropeanSwallowHasCorrectSpeed()
    {
        var bird = BirdFactory.GetBird(BirdType.EuropeanSwallow);
        Assert.Equal(20, bird.GetAirspeedVelocity());
    }

    [Fact]
    public void LadenEuropeanSwallowHasCorrectSpeed()
    {
        var bird = BirdFactory.GetBird(BirdType.EuropeanSwallow);
        bird.ApplyLoad(BirdLoad.Coconut);
        Assert.Equal(16, bird.GetAirspeedVelocity());
    }
}