namespace DirectN;

[GeneratedComInterface, Guid("3945b85b-bc95-40f7-b72c-8b73bfc7e13b")]
public partial interface IDWriteFontFace7 : IDWriteFontFace6
{
    [PreserveSig]
    public DirectWriteDWRITE_PAINT_FEATURE_LEVEL GetPaintFeatureLevel(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePaintReader(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, DirectWriteDWRITE_PAINT_FEATURE_LEVEL paintFeatureLevel, out IDWritePaintReader paintReader);
}
