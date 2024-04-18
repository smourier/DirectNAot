namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debugcommandlist
[GeneratedComInterface, Guid("09e0bf36-54ac-484f-8847-4baeeab6053f")]
public partial interface ID3D12DebugCommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist-assertresourcestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist-setfeaturemask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist-getfeaturemask
    [PreserveSig]
    public D3D12_DEBUG_FEATURE GetFeatureMask();
}
