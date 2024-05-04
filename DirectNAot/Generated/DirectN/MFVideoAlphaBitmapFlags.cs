#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr9/ne-evr9-mfvideoalphabitmapflags
public enum MFVideoAlphaBitmapFlags
{
    MFVideoAlphaBitmap_EntireDDS = 1,
    MFVideoAlphaBitmap_SrcColorKey = 2,
    MFVideoAlphaBitmap_SrcRect = 4,
    MFVideoAlphaBitmap_DestRect = 8,
    MFVideoAlphaBitmap_FilterMode = 16,
    MFVideoAlphaBitmap_Alpha = 32,
    MFVideoAlphaBitmap_BitMask = 63,
}
