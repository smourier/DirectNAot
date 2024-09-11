#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontfallbackbuilder
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("fd882d06-8aba-4fb8-b849-8be8b73e14de")]
public partial interface IDWriteFontFallbackBuilder
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritefontfallbackbuilder-addmapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMapping([In][MarshalUsing(CountElementName = nameof(rangesCount))] DWRITE_UNICODE_RANGE[] ranges, uint rangesCount, [In][MarshalUsing(CountElementName = nameof(targetFamilyNamesCount))] ushort[] targetFamilyNames, uint targetFamilyNamesCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection?>))] IDWriteFontCollection? fontCollection, PWSTR localeName, PWSTR baseFamilyName, float scale);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontfallbackbuilder-addmappings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMappings([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFallback>))] IDWriteFontFallback fontFallback);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontfallbackbuilder-createfontfallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFallback>))] out IDWriteFontFallback fontFallback);
}
