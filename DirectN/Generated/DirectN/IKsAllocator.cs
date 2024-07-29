#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8da64899-c0d9-11d0-8413-0000f822fe8a")]
public partial interface IKsAllocator
{
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    HANDLE KsGetAllocatorHandle();
    
    [PreserveSig]
    KSALLOCATORMODE KsGetAllocatorMode();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetAllocatorStatus(out KSSTREAMALLOCATOR_STATUS AllocatorStatus);
    
    [PreserveSig]
    void KsSetAllocatorMode(KSALLOCATORMODE Mode);
}
