namespace MyFirstLibrary
{
    /// <summary>
    /// Every class inside this Library implements this interface.
    /// </summary>
    public interface IMyFirstLibrary
    {
        void Initialize();
        void Run();
        void Abort();
        void Dispose();
    }
}
