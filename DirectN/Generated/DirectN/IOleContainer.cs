#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-iolecontainer
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000011b-0000-0000-c000-000000000046")]
public partial interface IOleContainer : IParseDisplayName
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolecontainer-enumobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumObjects(uint grfFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumUnknown>))] out IEnumUnknown ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-iolecontainer-lockcontainer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockContainer(BOOL fLock);
}
