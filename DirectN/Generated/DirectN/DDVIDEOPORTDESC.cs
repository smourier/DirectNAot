#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvp/ns-dvp-ddvideoportdesc
[StructLayout(LayoutKind.Sequential)]
public partial struct DDVIDEOPORTDESC
{
    public uint dwSize;
    public uint dwFieldWidth;
    public uint dwVBIWidth;
    public uint dwFieldHeight;
    public uint dwMicrosecondsPerField;
    public uint dwMaxPixelsPerSecond;
    public uint dwVideoPortID;
    public uint dwReserved1;
    public DDVIDEOPORTCONNECT VideoPortType;
    public nuint dwReserved2;
    public nuint dwReserved3;
}
