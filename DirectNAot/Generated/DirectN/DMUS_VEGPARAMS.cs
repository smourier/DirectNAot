namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_VEGPARAMS
{
    public int tcAttack;
    public int tcDecay;
    public int ptSustain;
    public int tcRelease;
    public int tcVel2Attack;
    public int tcKey2Decay;
}
