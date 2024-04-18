namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTOUTPUTFORMATDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpddpfInputFormat;
    public nint lpddpfOutputFormats;
    public uint dwNumFormats;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetVideoPortOutputFormats;
}
