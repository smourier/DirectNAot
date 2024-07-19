namespace DirectN.Extensions;

public static class IDXGIDeviceSubObjectExtensions
{
    public static IComObject<IDXGIDevice> GetDevice(this IDXGIDeviceSubObject subObject)
    {
        ArgumentNullException.ThrowIfNull(subObject);
        subObject.GetDevice(typeof(IDXGIDevice).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<IDXGIDevice>(unk)!;
    }

    [SupportedOSPlatform("windows6.1")]
    public static IComObject<IDXGIDevice1> GetDevice1(this IDXGIDeviceSubObject subObject)
    {
        ArgumentNullException.ThrowIfNull(subObject);
        subObject.GetDevice(typeof(IDXGIDevice1).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<IDXGIDevice1>(unk)!;
    }
}
