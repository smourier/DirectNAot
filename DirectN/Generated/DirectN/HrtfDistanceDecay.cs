#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtfdistancedecay
public partial struct HrtfDistanceDecay
{
    public HrtfDistanceDecayType type;
    public float maxGain;
    public float minGain;
    public float unityGainDistance;
    public float cutoffDistance;
}
