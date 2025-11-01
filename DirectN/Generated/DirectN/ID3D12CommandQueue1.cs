#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3a3c3165-0ee7-4b8e-a0af-6356b4c3bbb9")]
public partial interface ID3D12CommandQueue1 : ID3D12CommandQueue
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProcessPriority(D3D12_COMMAND_QUEUE_PROCESS_PRIORITY Priority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcessPriority(ref D3D12_COMMAND_QUEUE_PROCESS_PRIORITY pOutValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGlobalPriority(D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY Priority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlobalPriority(ref D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY pOutValue);
}
