namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSSTREAM_METADATA_INFO
{
    public uint BufferSize;
    public uint UsedSize;
    public nint Data;
    public nint SystemVa;
    public uint Flags;
    public uint Reserved;
}
