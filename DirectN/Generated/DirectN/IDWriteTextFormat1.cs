#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextformat1
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("5f174b49-0d8b-4cfb-8bca-f1cce9d06c67")]
public partial interface IDWriteTextFormat1 : IDWriteTextFormat
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextformat1-setverticalglyphorientation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextformat1-getverticalglyphorientation
    [PreserveSig]
    DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextformat1-setlastlinewrapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLastLineWrapping(BOOL isLastLineWrappingEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextformat1-getlastlinewrapping
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL GetLastLineWrapping();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextformat1-setopticalalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextformat1-getopticalalignment
    [PreserveSig]
    DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextformat1-setfontfallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFontFallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFallback>))] IDWriteFontFallback fontFallback);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritetextformat1-getfontfallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFallback>))] out IDWriteFontFallback fontFallback);
}
