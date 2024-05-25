#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-enlowfirtf
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct ENLOWFIRTF
{
    public NMHDR nmhdr;
    public PSTR szControl;
}
