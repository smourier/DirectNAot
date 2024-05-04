#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-graycolor
[StructLayout(LayoutKind.Sequential)]
public partial struct GRAYCOLOR
{
    public ushort gray;
}
