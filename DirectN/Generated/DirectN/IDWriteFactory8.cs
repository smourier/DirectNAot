#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ee0a7fb5-def4-4c23-a454-c9c7dc878398")]
public partial interface IDWriteFactory8 : IDWriteFactory7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateColorGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, nint /* optional DWRITE_GLYPH_RUN_DESCRIPTION* */ glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_PAINT_FEATURE_LEVEL paintFeatureLevel, DWRITE_MEASURING_MODE measuringMode, nint /* optional DWRITE_MATRIX* */ worldAndDpiTransform, uint colorPaletteIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteColorGlyphRunEnumerator1>))] out IDWriteColorGlyphRunEnumerator1 colorEnumerator);
}
