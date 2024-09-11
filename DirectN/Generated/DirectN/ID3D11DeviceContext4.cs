#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11devicecontext4
[GeneratedComInterface, Guid("917600da-f58c-4c33-98d8-3e15b390fa24")]
public partial interface ID3D11DeviceContext4 : ID3D11DeviceContext3
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11devicecontext4-signal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Signal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Fence>))] ID3D11Fence pFence, ulong Value);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11devicecontext4-wait
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Wait([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11Fence>))] ID3D11Fence pFence, ulong Value);
}
