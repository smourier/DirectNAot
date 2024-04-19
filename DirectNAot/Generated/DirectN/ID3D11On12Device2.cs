namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11on12/nn-d3d11on12-id3d11on12device2
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("dc90f331-4740-43fa-866e-67f12cb58223")]
public partial interface ID3D11On12Device2 : ID3D11On12Device1
{
    // https://learn.microsoft.com/windows/win32/api/d3d11on12/nf-d3d11on12-id3d11on12device2-unwrapunderlyingresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnwrapUnderlyingResource(ID3D11Resource pResource11, ID3D12CommandQueue pCommandQueue, in Guid riid, out nint ppvResource12);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11on12/nf-d3d11on12-id3d11on12device2-returnunderlyingresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReturnUnderlyingResource(ID3D11Resource pResource11, uint NumSync, in ulong pSignalValues, in ID3D12Fence ppFences);
}
