namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SETEXCLUSIVEMODEDATA
{
    public nint lpDD;
    public uint dwEnterExcl;
    public uint dwReserved;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint SetExclusiveMode;
}
