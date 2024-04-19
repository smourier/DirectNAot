namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwriteremotefontfileloader
[GeneratedComInterface, Guid("68648c83-6ede-46c0-ab46-20083a887fde")]
public partial interface IDWriteRemoteFontFileLoader : IDWriteFontFileLoader
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteremotefontfileloader-createremotestreamfromkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRemoteStreamFromKey(nint fontFileReferenceKey, uint fontFileReferenceKeySize, out IDWriteRemoteFontFileStream fontFileStream);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteremotefontfileloader-getlocalityfromkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocalityFromKey(nint fontFileReferenceKey, uint fontFileReferenceKeySize, out DWRITE_LOCALITY locality);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwriteremotefontfileloader-createfontfilereferencefromurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFileReferenceFromUrl(IDWriteFactory factory, PWSTR baseUrl, PWSTR fontFileUrl, out IDWriteFontFile fontFile);
}
