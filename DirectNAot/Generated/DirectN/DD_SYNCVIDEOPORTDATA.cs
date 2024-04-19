namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_syncvideoportdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SYNCVIDEOPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwOriginOffset;
    public uint dwHeight;
    public uint dwVBIHeight;
    public uint dwDriverReserved1;
    public uint dwDriverReserved2;
    public uint dwDriverReserved3;
    public HRESULT ddRVal;
}
