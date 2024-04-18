namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTLINEDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwLine;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetVideoPortLine;
}
