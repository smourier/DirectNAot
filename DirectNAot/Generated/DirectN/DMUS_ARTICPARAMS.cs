#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_ARTICPARAMS
{
    public DMUS_LFOPARAMS LFO;
    public DMUS_VEGPARAMS VolEG;
    public DMUS_PEGPARAMS PitchEG;
    public DMUS_MSCPARAMS Misc;
}
