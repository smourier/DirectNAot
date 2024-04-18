namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ns-dwmapi-dwm_present_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct DWM_PRESENT_PARAMETERS
{
    public uint cbSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fQueue;
    public ulong cRefreshStart;
    public uint cBuffer;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fUseSourceRate;
    public UNSIGNED_RATIO rateSource;
    public uint cRefreshesPerFrame;
    public DWM_SOURCE_FRAME_SAMPLING eSampling;
}
