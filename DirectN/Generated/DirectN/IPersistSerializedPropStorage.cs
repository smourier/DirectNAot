#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/nn-propsys-ipersistserializedpropstorage
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e318ad57-0aa0-450f-aca5-6fab7103d917")]
public partial interface IPersistSerializedPropStorage
{
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipersistserializedpropstorage-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(int flags);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipersistserializedpropstorage-setpropertystorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyStorage(PCUSERIALIZEDPROPSTORAGE psps, uint cb);
    
    // https://learn.microsoft.com/windows/win32/api/propsys/nf-propsys-ipersistserializedpropstorage-getpropertystorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyStorage(out nint ppsps, out uint pcb);
}
