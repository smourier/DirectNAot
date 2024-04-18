namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getscanlinedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETSCANLINEDATA
{
    public nint lpDD;
    public uint dwScanLine;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetScanLine;
}
