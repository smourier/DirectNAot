#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2fx/ns-xaudio2fx-xaudio2fx_volumemeter_levels
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2FX_VOLUMEMETER_LEVELS
{
    public nint pPeakLevels;
    public nint pRMSLevels;
    public uint ChannelCount;
}
