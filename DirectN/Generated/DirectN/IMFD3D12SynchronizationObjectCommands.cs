#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfd3d12/nn-mfd3d12-imfd3d12synchronizationobjectcommands
[GeneratedComInterface, Guid("09d0f835-92ff-4e53-8efa-40faa551f233")]
public partial interface IMFD3D12SynchronizationObjectCommands
{
    // https://learn.microsoft.com/windows/win32/api/mfd3d12/nf-mfd3d12-imfd3d12synchronizationobjectcommands-enqueueresourceready
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueResourceReady([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CommandQueue>))] ID3D12CommandQueue pProducerCommandQueue);
    
    // https://learn.microsoft.com/windows/win32/api/mfd3d12/nf-mfd3d12-imfd3d12synchronizationobjectcommands-enqueueresourcereadywait
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueResourceReadyWait([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CommandQueue>))] ID3D12CommandQueue pConsumerCommandQueue);
    
    // https://learn.microsoft.com/windows/win32/api/mfd3d12/nf-mfd3d12-imfd3d12synchronizationobjectcommands-signaleventonresourceready
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SignalEventOnResourceReady(HANDLE hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfd3d12/nf-mfd3d12-imfd3d12synchronizationobjectcommands-enqueueresourcerelease
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueResourceRelease([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12CommandQueue>))] ID3D12CommandQueue pConsumerCommandQueue);
}
