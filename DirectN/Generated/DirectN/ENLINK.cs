#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-enlink
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct ENLINK
{
    public NMHDR nmhdr;
    public uint msg;
    public WPARAM wParam;
    public LPARAM lParam;
    public CHARRANGE chrg;
}
