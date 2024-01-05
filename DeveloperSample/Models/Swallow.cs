using DeveloperSample.Enums;

namespace DeveloperSample.Models;

public class Swallow
{
    public SwallowType Type { get; }
    public SwallowLoad Load { get; private set; }

    public Swallow(SwallowType swallowType)
    {
        Type = swallowType;
    }

    public void ApplyLoad(SwallowLoad load)
    {
        Load = load;
    }

    public double GetAirspeedVelocity()
    {
        return Type switch
        {
            SwallowType.African => Load == SwallowLoad.None ? 22 : 18,
            SwallowType.European => (double)(Load == SwallowLoad.None ? 20 : 16),
            _ => throw new InvalidOperationException(),
        };
    }
}