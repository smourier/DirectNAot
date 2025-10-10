namespace DirectN;

[Flags]
public enum GILIN
{
    GIL_NONE = 0,
    GIL_OPENICON = 0x0001,
    GIL_FORSHELL = 0x0002,
    GIL_ASYNC = 0x0020,
    GIL_DEFAULTICON = 0x0040,
    GIL_FORSHORTCUT = 0x0080,
    GIL_CHECKSHIELD = 0x0200,
}
