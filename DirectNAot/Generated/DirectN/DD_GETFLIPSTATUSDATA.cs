namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getflipstatusdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETFLIPSTATUSDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint dwFlags;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetFlipStatus;
}
