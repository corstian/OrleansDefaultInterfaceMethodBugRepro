using Orleans;

namespace OrleansInterfaceBugRepro
{
    public class TestGrain<T> : Grain, ITestGrain<T>
    {
        public Task<int> Method(T t)
        {
            throw new NotImplementedException();
        }
    }
}
