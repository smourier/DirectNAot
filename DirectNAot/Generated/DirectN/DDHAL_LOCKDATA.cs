namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_LOCKDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public uint bHasRect;
    public RECTL rArea;
    public nint lpSurfData;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint Lock;
    public uint dwFlags;
}
