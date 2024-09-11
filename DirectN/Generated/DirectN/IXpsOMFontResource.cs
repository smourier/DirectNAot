#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomfontresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a8c45708-47d9-4af4-8d20-33b48c9b8485")]
public partial interface IXpsOMFontResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresource-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream readerStream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresource-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream sourceStream, XPS_FONT_EMBEDDING embeddingOption, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresource-getembeddingoption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEmbeddingOption(out XPS_FONT_EMBEDDING embeddingOption);
}
