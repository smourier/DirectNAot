#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debugcommandlist
[GeneratedComInterface, Guid("09e0bf36-54ac-484f-8847-4baeeab6053f")]
public partial interface ID3D12DebugCommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist-assertresourcestate
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL AssertResourceState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12Resource>))] ID3D12Resource pResource, uint Subresource, uint State);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist-setfeaturemask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist-getfeaturemask
    [PreserveSig]
    D3D12_DEBUG_FEATURE GetFeatureMask();
}
