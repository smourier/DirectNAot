#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvp/ns-dvp-ddvideoportbandwidth
[StructLayout(LayoutKind.Sequential)]
public partial struct DDVIDEOPORTBANDWIDTH
{
    public uint dwSize;
    public uint dwCaps;
    public uint dwOverlay;
    public uint dwColorkey;
    public uint dwYInterpolate;
    public uint dwYInterpAndColorkey;
    public nuint dwReserved1;
    public nuint dwReserved2;
}
