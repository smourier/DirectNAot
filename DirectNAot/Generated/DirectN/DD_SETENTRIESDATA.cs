namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_setentriesdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_SETENTRIESDATA
{
    public nint lpDD;
    public nint lpDDPalette;
    public uint dwBase;
    public uint dwNumEntries;
    public nint lpEntries;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint SetEntries;
}
