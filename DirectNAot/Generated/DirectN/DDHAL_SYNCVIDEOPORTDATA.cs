namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SYNCVIDEOPORTDATA
{
    public uint dwSize;
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwOriginOffset;
    public uint dwHeight;
    public uint dwVBIHeight;
    public nuint dwDriverReserved1;
    public nuint dwDriverReserved2;
    public nuint dwDriverReserved3;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
}
