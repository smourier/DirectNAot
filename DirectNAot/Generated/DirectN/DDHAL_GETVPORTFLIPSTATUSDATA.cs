namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTFLIPSTATUSDATA
{
    public nint lpDD;
    public nuint fpSurface;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetVideoPortFlipStatus;
}
