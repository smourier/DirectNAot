#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windef/ns-windef-rectl
[StructLayout(LayoutKind.Sequential)]
public partial struct RECTL
{
    public int left;
    public int top;
    public int right;
    public int bottom;
}
