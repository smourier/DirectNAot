#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/ns-spatialaudiohrtf-spatialaudiohrtfdirectivityunion
[StructLayout(LayoutKind.Explicit)]
public partial struct SpatialAudioHrtfDirectivityUnion
{
    [FieldOffset(0)]
    public SpatialAudioHrtfDirectivityCone Cone;
    
    [FieldOffset(0)]
    public SpatialAudioHrtfDirectivityCardioid Cardiod;
    
    [FieldOffset(0)]
    public SpatialAudioHrtfDirectivity Omni;
}
