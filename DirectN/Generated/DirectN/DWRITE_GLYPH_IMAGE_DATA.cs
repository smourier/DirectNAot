#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ns-dwrite_3-dwrite_glyph_image_data
public partial struct DWRITE_GLYPH_IMAGE_DATA
{
    public nint imageData;
    public uint imageDataSize;
    public uint uniqueDataId;
    public uint pixelsPerEm;
    public D2D_SIZE_U pixelSize;
    public POINT horizontalLeftOrigin;
    public POINT horizontalRightOrigin;
    public POINT verticalTopOrigin;
    public POINT verticalBottomOrigin;
}
