#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ns-dwmapi-dwm_present_parameters
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_PRESENT_PARAMETERS
{
    public uint cbSize;
    public BOOL fQueue;
    public ulong cRefreshStart;
    public uint cBuffer;
    public BOOL fUseSourceRate;
    public UNSIGNED_RATIO rateSource;
    public uint cRefreshesPerFrame;
    public DWM_SOURCE_FRAME_SAMPLING eSampling;
}
