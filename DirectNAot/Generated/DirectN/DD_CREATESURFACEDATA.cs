namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_createsurfacedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_CREATESURFACEDATA
{
    public nint lpDD;
    public nint lpDDSurfaceDesc;
    public nint lplpSList;
    public uint dwSCnt;
    public HRESULT ddRVal;
    public nint CreateSurface;
}
