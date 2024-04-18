namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_querymocompstatusdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_QUERYMOCOMPSTATUSDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpSurface;
    public uint dwFlags;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
}
