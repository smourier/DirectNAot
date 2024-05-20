#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12devicechild
[GeneratedComInterface, Guid("905db94b-a00c-4140-9df5-2b64ca9ea357")]
public partial interface ID3D12DeviceChild : ID3D12Object
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12devicechild-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(in Guid riid, out nint /* void */ ppvDevice);
}
