namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontcollection2
[GeneratedComInterface, Guid("514039c6-4617-4064-bf8b-92ea83e506e0")]
public partial interface IDWriteFontCollection2 : IDWriteFontCollection1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontcollection2-getfontfamily
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontFamily(uint index, out IDWriteFontFamily2 fontFamily);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontcollection2-getmatchingfonts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMatchingFonts(PWSTR familyName, in DWRITE_FONT_AXIS_VALUE fontAxisValues, uint fontAxisValueCount, out IDWriteFontList2 fontList);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontcollection2-getfontfamilymodel
    [PreserveSig]
    public DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontcollection2-getfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontSet(out IDWriteFontSet1 fontSet);
}
