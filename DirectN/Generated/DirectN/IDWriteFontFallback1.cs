#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontfallback1
[GeneratedComInterface, Guid("2397599d-dd0d-4681-bd6a-f4f31eaade77")]
public partial interface IDWriteFontFallback1 : IDWriteFontFallback
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapCharacters(IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection? baseFontCollection, PWSTR baseFamilyName, [In][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, ref uint mappedLength, out float scale, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace5>))] out IDWriteFontFace5 mappedFontFace);
}
