#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_property_sphli
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_PROPERTY_SPHLI
{
    public ushort HLISS;
    public ushort Reserved;
    public uint StartPTM;
    public uint EndPTM;
    public ushort StartX;
    public ushort StartY;
    public ushort StopX;
    public ushort StopY;
    public AM_COLCON ColCon;
}
