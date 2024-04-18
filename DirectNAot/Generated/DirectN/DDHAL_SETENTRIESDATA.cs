namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SETENTRIESDATA
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
