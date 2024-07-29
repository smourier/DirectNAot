#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12protectedsession
[GeneratedComInterface, Guid("a1533d18-0ac1-4084-85b9-89a96116806b")]
public partial interface ID3D12ProtectedSession : ID3D12DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12protectedsession-getstatusfence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatusFence(in Guid riid, out nint /* void */ ppFence);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12protectedsession-getsessionstatus
    [PreserveSig]
    D3D12_PROTECTED_SESSION_STATUS GetSessionStatus();
}
