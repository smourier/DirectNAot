namespace DirectN;

public interface IValueGet
{
    object? GetValue();
}

public interface IValueGet<T> : IValueGet
{
    new T? GetValue();
}
