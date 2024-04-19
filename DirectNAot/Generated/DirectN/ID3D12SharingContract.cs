namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12sharingcontract
[GeneratedComInterface, Guid("0adf7d52-929c-4e61-addb-ffed30de66ef")]
public partial interface ID3D12SharingContract
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12sharingcontract-present
    [PreserveSig]
    void Present(ID3D12Resource pResource, uint Subresource, HWND window);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12sharingcontract-sharedfencesignal
    [PreserveSig]
    void SharedFenceSignal(ID3D12Fence pFence, ulong FenceValue);
    
    [PreserveSig]
    void BeginCapturableWork(in Guid guid);
    
    [PreserveSig]
    void EndCapturableWork(in Guid guid);
}
