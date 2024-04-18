namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefactory5
[GeneratedComInterface, Guid("958db99a-be2a-4f09-af7d-65189803d1d3")]
public partial interface IDWriteFactory5 : IDWriteFactory4
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory5-createfontsetbuilder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateFontSetBuilder(out IDWriteFontSetBuilder1 fontSetBuilder);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory5-createinmemoryfontfileloader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateInMemoryFontFileLoader(out IDWriteInMemoryFontFileLoader newLoader);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory5-createhttpfontfileloader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateHttpFontFileLoader(PWSTR referrerUrl, PWSTR extraHeaders, out IDWriteRemoteFontFileLoader newLoader);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory5-analyzecontainertype
    [PreserveSig]
    public DWRITE_CONTAINER_TYPE AnalyzeContainerType(nint fileData, uint fileDataSize);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory5-unpackfontfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UnpackFontFile(DWRITE_CONTAINER_TYPE containerType, nint fileData, uint fileDataSize, out IDWriteFontFileStream unpackedFontStream);
}
