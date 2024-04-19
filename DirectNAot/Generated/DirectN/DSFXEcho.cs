namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSFXEcho
{
    public float fWetDryMix;
    public float fFeedback;
    public float fLeftDelay;
    public float fRightDelay;
    public int lPanDelay;
}
