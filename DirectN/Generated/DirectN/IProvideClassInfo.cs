#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iprovideclassinfo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b283-bab4-101a-b69c-00aa00341d07")]
public partial interface IProvideClassInfo
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iprovideclassinfo-getclassinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClassInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeInfo>))] out ITypeInfo ppTI);
}
