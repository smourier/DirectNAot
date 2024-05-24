#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/ns-spatialaudiohrtf-spatialaudiohrtfdirectivitycardioid
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioHrtfDirectivityCardioid
{
    public SpatialAudioHrtfDirectivity directivity;
    public float Order;
}
