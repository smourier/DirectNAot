#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f343d1a0-afe3-439f-b13d-cd87a43b70ca")]
public partial interface ID3D12DSRDeviceFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDSRDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Device>))] ID3D12Device pD3D12Device, uint NodeMask, in Guid riid, out nint /* void */ ppvDSRDevice);
}
