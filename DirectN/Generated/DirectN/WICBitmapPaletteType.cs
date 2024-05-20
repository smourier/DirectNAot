#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicbitmappalettetype
public enum WICBitmapPaletteType
{
    WICBitmapPaletteTypeCustom = 0,
    WICBitmapPaletteTypeMedianCut = 1,
    WICBitmapPaletteTypeFixedBW = 2,
    WICBitmapPaletteTypeFixedHalftone8 = 3,
    WICBitmapPaletteTypeFixedHalftone27 = 4,
    WICBitmapPaletteTypeFixedHalftone64 = 5,
    WICBitmapPaletteTypeFixedHalftone125 = 6,
    WICBitmapPaletteTypeFixedHalftone216 = 7,
    WICBitmapPaletteTypeFixedWebPalette = 7,
    WICBitmapPaletteTypeFixedHalftone252 = 8,
    WICBitmapPaletteTypeFixedHalftone256 = 9,
    WICBitmapPaletteTypeFixedGray4 = 10,
    WICBitmapPaletteTypeFixedGray16 = 11,
    WICBitmapPaletteTypeFixedGray256 = 12,
}
