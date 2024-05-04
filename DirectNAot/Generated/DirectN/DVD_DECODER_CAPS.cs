#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_decoder_caps
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_DECODER_CAPS
{
    public uint dwSize;
    public uint dwAudioCaps;
    public double dFwdMaxRateVideo;
    public double dFwdMaxRateAudio;
    public double dFwdMaxRateSP;
    public double dBwdMaxRateVideo;
    public double dBwdMaxRateAudio;
    public double dBwdMaxRateSP;
    public uint dwRes1;
    public uint dwRes2;
    public uint dwRes3;
    public uint dwRes4;
}
