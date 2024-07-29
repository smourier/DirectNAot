#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12virtualizationguestdevice
[GeneratedComInterface, Guid("bc66d368-7373-4943-8757-fc87dc79e476")]
public partial interface ID3D12VirtualizationGuestDevice
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12virtualizationguestdevice-sharewithhost
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShareWithHost(ID3D12DeviceChild pObject, out HANDLE pHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12virtualizationguestdevice-createfencefd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFenceFd(ID3D12Fence pFence, ulong FenceValue, out int pFenceFd);
}
