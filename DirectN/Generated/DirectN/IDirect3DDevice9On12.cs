#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e7fda234-b589-4049-940d-8878977531c8")]
public partial interface IDirect3DDevice9On12
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetD3D12Device(in Guid riid, out nint ppvDevice);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnwrapUnderlyingResource(IDirect3DResource9 pResource, ID3D12CommandQueue pCommandQueue, in Guid riid, out nint ppvResource12);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReturnUnderlyingResource(IDirect3DResource9 pResource, uint NumSync, ref ulong pSignalValues, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Fence>))] out ID3D12Fence ppFences);
}
