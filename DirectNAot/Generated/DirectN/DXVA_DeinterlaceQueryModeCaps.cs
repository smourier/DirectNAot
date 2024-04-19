namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_DeinterlaceQueryModeCaps
{
    public uint Size;
    public Guid Guid;
    public DXVA_VideoDesc VideoDesc;
}
