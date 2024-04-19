namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MFT_STREAM_STATE_PARAM
{
    public uint StreamId;
    public MF_STREAM_STATE State;
}
