#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-encorrecttext
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct ENCORRECTTEXT
{
    public NMHDR nmhdr;
    public CHARRANGE chrg;
    public RICH_EDIT_GET_CONTEXT_MENU_SEL_TYPE seltyp;
}
