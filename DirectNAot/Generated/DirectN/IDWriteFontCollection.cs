namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontcollection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("a84cee02-3eea-4eee-a827-87c1a02a0fcc")]
public partial interface IDWriteFontCollection
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontcollection-getfontfamilycount
    [PreserveSig]
    public uint GetFontFamilyCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontcollection-getfontfamily
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontFamily(uint index, out IDWriteFontFamily fontFamily);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontcollection-findfamilyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FindFamilyName(PWSTR familyName, out uint index, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontcollection-getfontfromfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontFromFontFace(IDWriteFontFace fontFace, out IDWriteFont font);
}
