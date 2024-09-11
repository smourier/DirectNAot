#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomstoryfragmentsresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c2b3ca09-0473-4282-87ae-1780863223f0")]
public partial interface IXpsOMStoryFragmentsResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomstoryfragmentsresource-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOwner([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPageReference>))] out IXpsOMPageReference owner);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomstoryfragmentsresource-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream stream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomstoryfragmentsresource-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream sourceStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partName);
}
