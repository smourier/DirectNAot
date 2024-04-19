namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG_SERVICE_REQUEST
{
    public MPEG_REQUEST_TYPE Type;
    public MPEG_CONTEXT Context;
    public ushort Pid;
    public byte TableId;
    public MPEG2_FILTER Filter;
    public uint Flags;
}
