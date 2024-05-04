#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("aeb575cf-4e06-48be-ba3b-c450fc96652e")]
public partial interface ID3D12DebugCommandList2 : ID3D12DebugCommandList
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, nint pData, uint DataSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, nint pData, uint DataSize);
}
