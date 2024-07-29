#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefont
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("acd16696-8c14-4f5d-877e-fe3fc1d32737")]
public partial interface IDWriteFont
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getfontfamily
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFamily([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFamily>))] out IDWriteFontFamily fontFamily);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getweight
    [PreserveSig]
    DWRITE_FONT_WEIGHT GetWeight();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getstretch
    [PreserveSig]
    DWRITE_FONT_STRETCH GetStretch();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getstyle
    [PreserveSig]
    DWRITE_FONT_STYLE GetStyle();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-issymbolfont
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsSymbolFont();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getfacenames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFaceNames([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings names);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getinformationalstrings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings informationalStrings, out BOOL exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getsimulations
    [PreserveSig]
    DWRITE_FONT_SIMULATIONS GetSimulations();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-getmetrics
    [PreserveSig]
    void GetMetrics(out DWRITE_FONT_METRICS fontMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-hascharacter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasCharacter(uint unicodeValue, out BOOL exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefont-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] out IDWriteFontFace fontFace);
}
