#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12fence
[GeneratedComInterface, Guid("0a753dcf-c4d8-4b91-adf6-be5a60d95a76")]
public partial interface ID3D12Fence : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12fence-getcompletedvalue
    [PreserveSig]
    ulong GetCompletedValue();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12fence-seteventoncompletion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEventOnCompletion(ulong Value, HANDLE hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12fence-signal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Signal(ulong Value);
}
