#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_PERFRAMESETTING_CAP_HEADER
{
    public uint Size;
    public uint ItemCount;
    public ulong Flags;
}
