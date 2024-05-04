#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("091bb63a-603f-11d1-b067-00a0c9062802")]
public partial interface IKsAllocatorEx : IKsAllocator
{
    [PreserveSig]
    ALLOCATOR_PROPERTIES_EX KsGetProperties();
    
    [PreserveSig]
    void KsSetProperties(in ALLOCATOR_PROPERTIES_EX param0);
    
    [PreserveSig]
    void KsSetAllocatorHandle(HANDLE AllocatorHandle);
    
    [PreserveSig]
    HANDLE KsCreateAllocatorAndGetHandle(IKsPin KsPin);
}
