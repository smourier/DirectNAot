#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-namedcolor
[StructLayout(LayoutKind.Sequential)]
public partial struct NAMEDCOLOR
{
    public uint dwIndex;
}
