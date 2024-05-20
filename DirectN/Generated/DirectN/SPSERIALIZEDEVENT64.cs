#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPSERIALIZEDEVENT64
{
    public int _bitfield;
    public uint ulStreamNum;
    public ulong ullAudioStreamOffset;
    public ulong SerializedwParam;
    public long SerializedlParam;
}
