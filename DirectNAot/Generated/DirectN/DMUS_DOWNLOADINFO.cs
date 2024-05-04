#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_DOWNLOADINFO
{
    public uint dwDLType;
    public uint dwDLId;
    public uint dwNumOffsetTableEntries;
    public uint cbSize;
}
