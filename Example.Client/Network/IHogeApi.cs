namespace Example.Client.Network
{
    using Example.Library;

    [Api]
    public interface IHogeApi
    {
        int Add(int x, int y);

        [Method("Subtract")]
        int Sub([Parameter("x")] int a, [Parameter("y")] int b);
    }

    public interface IBar
    {
        int Test();
    }
}

namespace Example.Client.Network2
{
    public interface IHoge
    {
        void Test();
    }
}
