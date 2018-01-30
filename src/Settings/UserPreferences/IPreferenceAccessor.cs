namespace FiddlerSanitizer
{
    public interface IPreferenceAccessor<T>
    {
        void Set(string key, T value);
        T Get(string key);
    }
}