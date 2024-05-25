#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-clipboardformat
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct CLIPBOARDFORMAT
{
    public NMHDR nmhdr;
    public ushort cf;
}
