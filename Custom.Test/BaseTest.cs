namespace Custom.Test
{
    public abstract class BaseTest<T> where T: new()
    {
        protected T Tester { get; }
        
        protected BaseTest()
        {
            Tester = new T();
        }
    }
}