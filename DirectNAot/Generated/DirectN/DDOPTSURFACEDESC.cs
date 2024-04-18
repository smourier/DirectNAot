namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDOPTSURFACEDESC
{
    public uint dwSize;
    public uint dwFlags;
    public DDSCAPS2 ddSCaps;
    public DDOSCAPS ddOSCaps;
    public Guid guid;
    public uint dwCompressionRatio;
}
