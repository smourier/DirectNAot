#nullable enable
namespace DirectN;

public partial struct D3DFINDDEVICESEARCH
{
    public uint dwSize;
    public uint dwFlags;
    public BOOL bHardware;
    public uint dcmColorModel;
    public Guid guid;
    public uint dwCaps;
    public D3DPRIMCAPS dpcPrimCaps;
}
