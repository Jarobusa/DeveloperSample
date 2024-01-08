namespace DeveloperSample.Container;


/// <summary>
/// A simple container for binding interfaces to implementations
/// </summary>
public class Container : List<Type>
{
    Dictionary<Type, Type> ImplementationsByType = new();

    /// <summary>
    /// Bind an interface to an implementation
    /// </summary>
    /// <param name="interfaceType"></param>
    /// <param name="implementationType"></param>
    public void Bind(Type interfaceType, Type implementationType)
    {
        ImplementationsByType[interfaceType] = implementationType;
    }


    /// <summary>
    /// Get an instance of T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public T Get<T>()
    {
        var type = typeof(T);
        if (ImplementationsByType.ContainsKey(type))
        {
            type = ImplementationsByType[type];
        }

        var instance = Activator.CreateInstance(type);

        if (instance is null)
            throw new Exception("Instance of T is not found");

        return (T)instance!;
    }
}
