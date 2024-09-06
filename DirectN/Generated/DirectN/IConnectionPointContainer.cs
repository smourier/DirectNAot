#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iconnectionpointcontainer
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b284-bab4-101a-b69c-00aa00341d07")]
public partial interface IConnectionPointContainer
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iconnectionpointcontainer-enumconnectionpoints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumConnectionPoints([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumConnectionPoints>))] out IEnumConnectionPoints ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iconnectionpointcontainer-findconnectionpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindConnectionPoint(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IConnectionPoint>))] out IConnectionPoint ppCP);
}
