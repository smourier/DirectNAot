#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/nn-d3d11_3-id3d11fence
[GeneratedComInterface, Guid("affde9d1-1df7-4bb7-8a34-0f46251dab80")]
public partial interface ID3D11Fence : ID3D11DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11fence-createsharedhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSharedHandle(nint /* optional SECURITY_ATTRIBUTES* */ pAttributes, uint dwAccess, PWSTR lpName, out HANDLE pHandle);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11fence-getcompletedvalue
    [PreserveSig]
    ulong GetCompletedValue();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_3/nf-d3d11_3-id3d11fence-seteventoncompletion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEventOnCompletion(ulong Value, HANDLE hEvent);
}
