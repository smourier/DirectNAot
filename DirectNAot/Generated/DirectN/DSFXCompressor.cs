namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSFXCompressor
{
    public float fGain;
    public float fAttack;
    public float fRelease;
    public float fThreshold;
    public float fRatio;
    public float fPredelay;
}
