#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipersistserializedpropstorage2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("77effa68-4f98-4366-ba72-573b3d880571")]
public partial interface IPersistSerializedPropStorage2 : IPersistSerializedPropStorage
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipersistserializedpropstorage2-getpropertystoragesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStorageSize(out uint pcb);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipersistserializedpropstorage2-getpropertystoragebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStorageBuffer(nint psps, uint cb, out uint pcbWritten);
}
