#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIOENGINE_VOLUMELEVEL
{
    public int TargetVolume;
    public AUDIO_CURVE_TYPE CurveType;
    public ulong CurveDuration;
}
