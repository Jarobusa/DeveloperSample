using DeveloperSample.Enums;
using DeveloperSample.Factories;
using Xunit;

namespace DeveloperSample.ClassRefactoring;
public class ClassRefactorTest
{
    [Fact]
    public void AfricanSwallowHasCorrectSpeed()
    {
        var swallow = BirdFactory.GetSwallow(BirdType.AfricanSwallow);
        Assert.Equal(22, swallow.GetAirspeedVelocity());
    }

    [Fact]
    public void LadenAfricanSwallowHasCorrectSpeed()
    {
        var swallow = BirdFactory.GetSwallow(BirdType.AfricanSwallow);
        swallow.ApplyLoad(BirdLoad.Coconut);
        Assert.Equal(18, swallow.GetAirspeedVelocity());
    }

    [Fact]
    public void EuropeanSwallowHasCorrectSpeed()
    {
        var swallow = BirdFactory.GetSwallow(BirdType.EuropeanSwallow);
        Assert.Equal(20, swallow.GetAirspeedVelocity());
    }

    [Fact]
    public void LadenEuropeanSwallowHasCorrectSpeed()
    {
        var swallow = BirdFactory.GetSwallow(BirdType.EuropeanSwallow);
        swallow.ApplyLoad(BirdLoad.Coconut);
        Assert.Equal(16, swallow.GetAirspeedVelocity());
    }
}