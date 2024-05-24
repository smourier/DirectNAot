#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/ns-spatialaudiohrtf-spatialaudiohrtfdirectivitycone
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioHrtfDirectivityCone
{
    public SpatialAudioHrtfDirectivity directivity;
    public float InnerAngle;
    public float OuterAngle;
}
