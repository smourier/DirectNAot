#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_PERFRAMESETTING_ITEM_HEADER
{
    public uint Size;
    public uint Type;
    public ulong Flags;
}
