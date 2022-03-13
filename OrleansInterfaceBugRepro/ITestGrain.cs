using Orleans;

namespace OrleansInterfaceBugRepro
{
    public interface ITestGrain<T> : IGrainWithGuidKey, ITestInterface<T>
    {

    }
}
