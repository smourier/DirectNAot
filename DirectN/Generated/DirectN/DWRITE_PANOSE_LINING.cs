#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ne-dwrite_1-dwrite_panose_lining
public enum DWRITE_PANOSE_LINING
{
    DWRITE_PANOSE_LINING_ANY = 0,
    DWRITE_PANOSE_LINING_NO_FIT = 1,
    DWRITE_PANOSE_LINING_NONE = 2,
    DWRITE_PANOSE_LINING_INLINE = 3,
    DWRITE_PANOSE_LINING_OUTLINE = 4,
    DWRITE_PANOSE_LINING_ENGRAVED = 5,
    DWRITE_PANOSE_LINING_SHADOW = 6,
    DWRITE_PANOSE_LINING_RELIEF = 7,
    DWRITE_PANOSE_LINING_BACKDROP = 8,
}
