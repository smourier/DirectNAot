#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/ns-spatialaudiohrtf-spatialaudiohrtfdirectivity
[StructLayout(LayoutKind.Sequential)]
public partial struct SpatialAudioHrtfDirectivity
{
    public SpatialAudioHrtfDirectivityType Type;
    public float Scaling;
}
