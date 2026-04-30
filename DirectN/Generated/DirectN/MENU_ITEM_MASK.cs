#nullable enable
namespace DirectN;

[Flags]
public enum MENU_ITEM_MASK : uint
{
    MIIM_BITMAP = 128,
    MIIM_CHECKMARKS = 8,
    MIIM_DATA = 32,
    MIIM_FTYPE = 256,
    MIIM_ID = 2,
    MIIM_STATE = 1,
    MIIM_STRING = 64,
    MIIM_SUBMENU = 4,
    MIIM_TYPE = 16,
}
