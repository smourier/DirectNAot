#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomdocumentstructureresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("85febc8a-6b63-48a9-af07-7064e4ecff30")]
public partial interface IXpsOMDocumentStructureResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdocumentstructureresource-getowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOwner([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMDocument>))] out IXpsOMDocument owner);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdocumentstructureresource-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream stream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomdocumentstructureresource-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream sourceStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partName);
}
