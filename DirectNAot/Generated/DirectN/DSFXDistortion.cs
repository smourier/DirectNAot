namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSFXDistortion
{
    public float fGain;
    public float fEdge;
    public float fPostEQCenterFrequency;
    public float fPostEQBandwidth;
    public float fPreLowpassCutoff;
}
