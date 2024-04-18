namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTINPUTFORMATDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpddpfFormat;
    public uint dwNumFormats;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetVideoPortInputFormats;
}
