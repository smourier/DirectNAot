namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_PUBLIC_ACCESS_RANGES
{
    public uint InIoSpace;
    public uint MappedInIoSpace;
    public nint VirtualAddress;
}
