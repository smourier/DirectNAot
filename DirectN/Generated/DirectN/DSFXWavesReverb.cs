#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSFXWavesReverb
{
    public float fInGain;
    public float fReverbMix;
    public float fReverbTime;
    public float fHighFreqRTRatio;
}
