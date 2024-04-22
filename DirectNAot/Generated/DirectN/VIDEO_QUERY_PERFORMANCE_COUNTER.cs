namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_QUERY_PERFORMANCE_COUNTER
{
    public uint BufferSize;
    public nint Buffer;
}
