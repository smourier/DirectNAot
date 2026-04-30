#nullable enable
namespace DirectN;

[Flags]
public enum MENU_ITEM_STATE : uint
{
    MFS_GRAYED = 3,
    MFS_DISABLED = 3,
    MFS_CHECKED = 8,
    MFS_HILITE = 128,
    MFS_ENABLED = 0,
    MFS_UNCHECKED = 0,
    MFS_UNHILITE = 0,
    MFS_DEFAULT = 4096,
}
