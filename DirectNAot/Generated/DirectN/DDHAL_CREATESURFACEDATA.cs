namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_CREATESURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurfaceDesc;
    public nint lplpSList;
    public uint dwSCnt;
    public HRESULT ddRVal;
    public nint CreateSurface;
}
