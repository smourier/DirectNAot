#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-ensaveclipboard
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct ENSAVECLIPBOARD
{
    public NMHDR nmhdr;
    public int cObjectCount;
    public int cch;
}
