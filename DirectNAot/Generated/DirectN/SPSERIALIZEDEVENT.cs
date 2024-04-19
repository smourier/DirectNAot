namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPSERIALIZEDEVENT
{
    public int _bitfield;
    public uint ulStreamNum;
    public ulong ullAudioStreamOffset;
    public uint SerializedwParam;
    public int SerializedlParam;
}
