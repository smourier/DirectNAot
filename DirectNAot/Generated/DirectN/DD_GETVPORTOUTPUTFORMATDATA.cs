namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportoutputformatdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETVPORTOUTPUTFORMATDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public nint lpddpfInputFormat;
    public nint lpddpfOutputFormats;
    public uint dwNumFormats;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetVideoPortInputFormats;
}
