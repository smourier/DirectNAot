namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_BUFFERDESC
{
    public uint dwSize;
    public uint dwFlags;
    public Guid guidBufferFormat;
    public uint cbBuffer;
}
