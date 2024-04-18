namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_CREATESURFACEEXDATA
{
    public uint dwFlags;
    public nint lpDDLcl;
    public nint lpDDSLcl;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
}
