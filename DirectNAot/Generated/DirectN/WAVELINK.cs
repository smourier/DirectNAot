#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WAVELINK
{
    public ushort fusOptions;
    public ushort usPhaseGroup;
    public uint ulChannel;
    public uint ulTableIndex;
}
