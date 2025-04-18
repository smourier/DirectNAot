#nullable enable
namespace DirectN;

public partial struct KSDS3D_HRTF_PARAMS_MSG
{
    public uint Size;
    public uint Enabled;
    public BOOL SwapChannels;
    public BOOL ZeroAzimuth;
    public BOOL CrossFadeOutput;
    public uint FilterSize;
}
