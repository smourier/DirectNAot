namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontfallbackbuilder
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("fd882d06-8aba-4fb8-b849-8be8b73e14de")]
public partial interface IDWriteFontFallbackBuilder
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontfallbackbuilder-addmapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMapping(in DWRITE_UNICODE_RANGE ranges, uint rangesCount, in ushort targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection fontCollection, PWSTR localeName, PWSTR baseFamilyName, float scale);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontfallbackbuilder-addmappings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMappings(IDWriteFontFallback fontFallback);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontfallbackbuilder-createfontfallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFallback(out IDWriteFontFallback fontFallback);
}
