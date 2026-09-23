namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class DCompositionFunctions
{
    public static IComObject<IDCompositionDevice> DCompositionCreateDevice(IComObject<IDXGIDevice>? dxgiDevice) => DCompositionCreateDevice<IDCompositionDevice>(dxgiDevice?.Object);
    public static IComObject<T> DCompositionCreateDevice<T>(IComObject<IDXGIDevice>? dxgiDevice) => DCompositionCreateDevice<T>(dxgiDevice?.Object);
    public static IComObject<T> DCompositionCreateDevice<T>(IDXGIDevice? dxgiDevice)
    {
        Functions.DCompositionCreateDevice(dxgiDevice, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }
}
