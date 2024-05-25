#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-reqresize
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct REQRESIZE
{
    public NMHDR nmhdr;
    public RECT rc;
}
