namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwriteinmemoryfontfileloader
[GeneratedComInterface, Guid("dc102f47-a12d-4b1c-822d-9e117e33043f")]
public partial interface IDWriteInMemoryFontFileLoader : IDWriteFontFileLoader
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteinmemoryfontfileloader-createinmemoryfontfilereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInMemoryFontFileReference(IDWriteFactory factory, nint fontData, uint fontDataSize, nint ownerObject, out IDWriteFontFile fontFile);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteinmemoryfontfileloader-getfilecount
    [PreserveSig]
    uint GetFileCount();
}
