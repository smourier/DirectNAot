#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/nn-d3d11-id3d11view
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("839d1216-bb2e-412b-b7f4-a9dbebe08ed1")]
public partial interface ID3D11View : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11/nf-d3d11-id3d11view-getresource
    [PreserveSig]
    void GetResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Resource>))] out ID3D11Resource ppResource);
}
