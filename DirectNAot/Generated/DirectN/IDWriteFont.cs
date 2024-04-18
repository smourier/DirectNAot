namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefont
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("acd16696-8c14-4f5d-877e-fe3fc1d32737")]
public partial interface IDWriteFont
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getfontfamily
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontFamily(out IDWriteFontFamily fontFamily);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getweight
    [PreserveSig]
    public DWRITE_FONT_WEIGHT GetWeight();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getstretch
    [PreserveSig]
    public DWRITE_FONT_STRETCH GetStretch();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getstyle
    [PreserveSig]
    public DWRITE_FONT_STYLE GetStyle();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-issymbolfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsSymbolFont();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getfacenames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFaceNames(out IDWriteLocalizedStrings names);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getinformationalstrings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, out IDWriteLocalizedStrings informationalStrings, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getsimulations
    [PreserveSig]
    public DWRITE_FONT_SIMULATIONS GetSimulations();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getmetrics
    [PreserveSig]
    public void GetMetrics(out DWRITE_FONT_METRICS fontMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-hascharacter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT HasCharacter(uint unicodeValue, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateFontFace(out IDWriteFontFace fontFace);
}
