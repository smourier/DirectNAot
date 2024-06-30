#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/ns-oleidl-oleverb
public partial struct OLEVERB
{
    public OLEIVERB lVerb;
    public PWSTR lpszVerbName;
    public MENU_ITEM_FLAGS fuFlags;
    public uint grfAttribs;
}
