#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontface3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("d37d7598-09be-4222-a236-2081341cc1f2")]
public partial interface IDWriteFontFace3 : IDWriteFontFace2
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFaceReference([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference>))] out IDWriteFontFaceReference fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getpanose
    [PreserveSig]
    void GetPanose(out DWRITE_PANOSE panose);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getweight
    [PreserveSig]
    DWRITE_FONT_WEIGHT GetWeight();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getstretch
    [PreserveSig]
    DWRITE_FONT_STRETCH GetStretch();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getstyle
    [PreserveSig]
    DWRITE_FONT_STYLE GetStyle();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getfamilynames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFamilyNames([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings names);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getfacenames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFaceNames([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings names);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getinformationalstrings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings informationalStrings, out BOOL exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-hascharacter
    [PreserveSig]
    BOOL HasCharacter(uint unicodeValue);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-getrecommendedrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, nint /* optional DWRITE_MATRIX* */ transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams? renderingParams, out DWRITE_RENDERING_MODE1 renderingMode, out DWRITE_GRID_FIT_MODE gridFitMode);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-ischaracterlocal
    [PreserveSig]
    BOOL IsCharacterLocal(uint unicodeValue);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-isglyphlocal
    [PreserveSig]
    BOOL IsGlyphLocal(ushort glyphId);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-arecharacterslocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AreCharactersLocal([MarshalUsing(CountElementName = nameof(characterCount))] PWSTR characters, uint characterCount, BOOL enqueueIfNotLocal, out BOOL isLocal);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface3-areglyphslocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AreGlyphsLocal([In][MarshalUsing(CountElementName = nameof(glyphCount))] ushort[] glyphIndices, uint glyphCount, BOOL enqueueIfNotLocal, out BOOL isLocal);
}
