namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_SHARE_MEMORY
{
    public HANDLE ProcessHandle;
    public uint ViewOffset;
    public uint ViewSize;
    public nint RequestedVirtualAddress;
}
