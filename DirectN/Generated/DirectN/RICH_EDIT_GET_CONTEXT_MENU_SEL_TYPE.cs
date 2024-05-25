#nullable enable
namespace DirectN;

[Flags]
public enum RICH_EDIT_GET_CONTEXT_MENU_SEL_TYPE : ushort
{
    SEL_EMPTY = 0,
    SEL_TEXT = 1,
    SEL_OBJECT = 2,
    SEL_MULTICHAR = 4,
    SEL_MULTIOBJECT = 8,
    GCM_RIGHTMOUSEDROP = 32768,
}
