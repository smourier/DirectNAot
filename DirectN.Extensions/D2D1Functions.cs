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

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<ID2D1Device> D2D1CreateDevice(IComObject<IDXGIDevice> dxgiDevice, D2D1_CREATION_PROPERTIES? creationProperties = null) => D2D1CreateDevice<ID2D1Device>(dxgiDevice?.Object!, creationProperties);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> D2D1CreateDevice<T>(IComObject<IDXGIDevice> dxgiDevice, D2D1_CREATION_PROPERTIES? creationProperties = null) where T : ID2D1Device => D2D1CreateDevice<T>(dxgiDevice?.Object!, creationProperties);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> D2D1CreateDevice<T>(IDXGIDevice dxgiDevice, D2D1_CREATION_PROPERTIES? creationProperties = null) where T : ID2D1Device
    {
        ArgumentNullException.ThrowIfNull(dxgiDevice);
        Functions.D2D1CreateDevice(dxgiDevice, creationProperties.CopyToPointer(), out var device).ThrowOnError();
        return new ComObject<T>(device)!;
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<ID2D1DeviceContext> D2D1CreateDeviceContext(IComObject<IDXGISurface> surface, D2D1_CREATION_PROPERTIES? creationProperties = null) => D2D1CreateDeviceContext<ID2D1DeviceContext>(surface?.Object!, creationProperties);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> D2D1CreateDeviceContext<T>(IComObject<IDXGISurface> surface, D2D1_CREATION_PROPERTIES? creationProperties = null) => D2D1CreateDeviceContext<T>(surface?.Object!, creationProperties);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> D2D1CreateDeviceContext<T>(IDXGISurface surface, D2D1_CREATION_PROPERTIES? creationProperties = null)
    {
        ArgumentNullException.ThrowIfNull(surface);
        Functions.D2D1CreateDeviceContext(surface, creationProperties.CopyToPointer(), out var deviceContext).ThrowOnError();
        return new ComObject<T>(deviceContext)!;
    }
}
