#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgidevicesubobject
[GeneratedComInterface, Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6")]
public partial interface IDXGIDeviceSubObject : IDXGIObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevicesubobject-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(in Guid riid, out nint /* void */ ppDevice);
}
