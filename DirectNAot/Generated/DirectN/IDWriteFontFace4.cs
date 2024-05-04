#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontface4
[GeneratedComInterface, Guid("27f2a904-4eb8-441d-9678-0563f53e3e2f")]
public partial interface IDWriteFontFace4 : IDWriteFontFace3
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface4-getglyphimageformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphImageFormats(ushort glyphId, uint pixelsPerEmFirst, uint pixelsPerEmLast, out DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormats);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface4-getglyphimageformats
    [PreserveSig]
    DWRITE_GLYPH_IMAGE_FORMATS GetGlyphImageFormats();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface4-getglyphimagedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGlyphImageData(ushort glyphId, uint pixelsPerEm, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, out DWRITE_GLYPH_IMAGE_DATA glyphData, out nint glyphDataContext);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface4-releaseglyphimagedata
    [PreserveSig]
    void ReleaseGlyphImageData(nint glyphDataContext);
}
