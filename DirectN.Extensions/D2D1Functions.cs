namespace DirectN.Extensions;

[SupportedOSPlatform("windows6.1")]
public static class D2D1Functions
{
    public static IComObject<ID2D1Factory> D2D1CreateFactory(D2D1_FACTORY_TYPE type = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_MULTI_THREADED, D2D1_FACTORY_OPTIONS? options = null) => D2D1CreateFactory<ID2D1Factory>(type, options);
    [SupportedOSPlatform("windows8.0")]
    public static IComObject<ID2D1Factory1> D2D1CreateFactory1(D2D1_FACTORY_TYPE type = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_MULTI_THREADED, D2D1_FACTORY_OPTIONS? options = null) => D2D1CreateFactory<ID2D1Factory1>(type, options);
    public static IComObject<T> D2D1CreateFactory<T>(D2D1_FACTORY_TYPE type = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_MULTI_THREADED, D2D1_FACTORY_OPTIONS? options = null)
    {
        Functions.D2D1CreateFactory(type, typeof(T).GUID, options.CopyToPointer(), out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }
}
