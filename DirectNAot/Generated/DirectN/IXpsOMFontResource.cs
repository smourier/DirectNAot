namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomfontresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a8c45708-47d9-4af4-8d20-33b48c9b8485")]
public partial interface IXpsOMFontResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresource-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStream(out IStream readerStream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresource-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetContent(IStream sourceStream, XPS_FONT_EMBEDDING embeddingOption, IOpcPartUri partName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomfontresource-getembeddingoption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEmbeddingOption(out XPS_FONT_EMBEDDING embeddingOption);
}
