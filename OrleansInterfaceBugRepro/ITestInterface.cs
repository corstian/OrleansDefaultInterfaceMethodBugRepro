namespace OrleansInterfaceBugRepro
{
    public interface ITestInterface
    {
        Task<int> Method(object t);
    }

    public interface ITestInterface<T> : ITestInterface
    {
        Task<int> ITestInterface.Method(object t) => Method((T)t);

        Task<int> Method(T t);
    }
}
