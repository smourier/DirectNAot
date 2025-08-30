#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/com/pictype-constants
public enum PICTYPE : short
{
    PICTYPE_UNINITIALIZED = -1,
    PICTYPE_NONE = 0,
    PICTYPE_BITMAP = 1,
    PICTYPE_METAFILE = 2,
    PICTYPE_ICON = 3,
    PICTYPE_ENHMETAFILE = 4,
}
