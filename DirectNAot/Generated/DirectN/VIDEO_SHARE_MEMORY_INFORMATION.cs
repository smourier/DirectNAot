namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_SHARE_MEMORY_INFORMATION
{
    public uint SharedViewOffset;
    public uint SharedViewSize;
    public nint VirtualAddress;
}
