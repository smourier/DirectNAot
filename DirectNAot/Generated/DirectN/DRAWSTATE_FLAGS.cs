namespace DirectN;

public enum DRAWSTATE_FLAGS : uint
{
    DST_COMPLEX = 0,
    DST_TEXT = 1,
    DST_PREFIXTEXT = 2,
    DST_ICON = 3,
    DST_BITMAP = 4,
    DSS_NORMAL = 0,
    DSS_UNION = 16,
    DSS_DISABLED = 32,
    DSS_MONO = 128,
    DSS_HIDEPREFIX = 512,
    DSS_PREFIXONLY = 1024,
    DSS_RIGHT = 32768,
}
