namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_UPDATEVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lplpDDSurface;
    public nint lplpDDVBISurface;
    public nint lpVideoInfo;
    public uint dwFlags;
    public uint dwNumAutoflip;
    public uint dwNumVBIAutoflip;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint UpdateVideoPort;
}
