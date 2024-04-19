namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSDS3D_HRTF_PARAMS_MSG
{
    public uint Size;
    public uint Enabled;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool SwapChannels;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ZeroAzimuth;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool CrossFadeOutput;
    public uint FilterSize;
}
