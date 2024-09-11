#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomremotedictionaryresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c9bd7cd4-e16a-4bf8-8c84-c950af7a3061")]
public partial interface IXpsOMRemoteDictionaryResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomremotedictionaryresource-getdictionary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDictionary([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDictionary>))] out IXpsOMDictionary dictionary);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomremotedictionaryresource-setdictionary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDictionary([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDictionary>))] IXpsOMDictionary dictionary);
}
