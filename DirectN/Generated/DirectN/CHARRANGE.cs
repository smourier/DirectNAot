#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-charrange
[StructLayout(LayoutKind.Sequential)]
public partial struct CHARRANGE
{
    public int cpMin;
    public int cpMax;
}
