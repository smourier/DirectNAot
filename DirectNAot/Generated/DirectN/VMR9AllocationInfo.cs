namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9allocationinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9AllocationInfo
{
    public uint dwFlags;
    public uint dwWidth;
    public uint dwHeight;
    public D3DFORMAT Format;
    public D3DPOOL Pool;
    public uint MinBuffers;
    public SIZE szAspectRatio;
    public SIZE szNativeSize;
}
