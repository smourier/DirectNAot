namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SETMODEDATA
{
    public nint lpDD;
    public uint dwModeIndex;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint SetMode;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool inexcl;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool useRefreshRate;
}
