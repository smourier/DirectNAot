namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class ID2D1ResourceExtensions
{
    public static IComObject<ID2D1Factory> GetFactory(this IComObject<ID2D1Resource> resource) => GetFactory<ID2D1Factory>(resource?.Object!);
    public static IComObject<T> GetFactory<T>(this IComObject<ID2D1Resource> resource) where T : ID2D1Factory => GetFactory<T>(resource?.Object!);
    public static IComObject<T> GetFactory<T>(this ID2D1Resource resource) where T : ID2D1Factory
    {
        ArgumentNullException.ThrowIfNull(resource);
        resource.GetFactory(out var factory);
        return new ComObject<T>((T)factory);
    }
}
