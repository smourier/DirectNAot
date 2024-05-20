#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_SETMODEDATA
{
    public nint lpDD;
    public uint dwModeIndex;
    public HRESULT ddRVal;
    public nint SetMode;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool inexcl;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool useRefreshRate;
}
