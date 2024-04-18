namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DFINDDEVICESEARCH
{
    public uint dwSize;
    public uint dwFlags;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bHardware;
    public uint dcmColorModel;
    public Guid guid;
    public uint dwCaps;
    public D3DPRIMCAPS dpcPrimCaps;
}
