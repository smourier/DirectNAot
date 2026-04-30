#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-menuiteminfow
public partial struct MENUITEMINFOW
{
    public uint cbSize;
    public MENU_ITEM_MASK fMask;
    public MENU_ITEM_TYPE fType;
    public MENU_ITEM_STATE fState;
    public uint wID;
    public HMENU hSubMenu;
    public HBITMAP hbmpChecked;
    public HBITMAP hbmpUnchecked;
    public nuint dwItemData;
    public PWSTR dwTypeData;
    public uint cch;
    public HBITMAP hbmpItem;
}
