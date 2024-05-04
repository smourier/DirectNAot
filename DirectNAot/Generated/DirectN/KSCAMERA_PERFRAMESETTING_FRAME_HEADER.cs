#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_PERFRAMESETTING_FRAME_HEADER
{
    public uint Size;
    public uint Id;
    public uint ItemCount;
    public uint Reserved;
}
