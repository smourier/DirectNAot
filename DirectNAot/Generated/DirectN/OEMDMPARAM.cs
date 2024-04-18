namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OEMDMPARAM
{
    public uint cbSize;
    public nint pdriverobj;
    public HANDLE hPrinter;
    public HANDLE hModule;
    public nint pPublicDMIn;
    public nint pPublicDMOut;
    public nint pOEMDMIn;
    public nint pOEMDMOut;
    public uint cbBufSize;
}
