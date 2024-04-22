namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_POINTER_CAPABILITIES
{
    public uint Flags;
    public uint MaxWidth;
    public uint MaxHeight;
    public uint HWPtrBitmapStart;
    public uint HWPtrBitmapEnd;
}
