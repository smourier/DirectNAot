#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/ns-spatialaudiohrtf-spatialaudiohrtfdistancedecay
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioHrtfDistanceDecay
{
    public SpatialAudioHrtfDistanceDecayType Type;
    public float MaxGain;
    public float MinGain;
    public float UnityGainDistance;
    public float CutoffDistance;
}
