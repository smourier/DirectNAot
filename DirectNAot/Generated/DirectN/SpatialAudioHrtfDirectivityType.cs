#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/ne-spatialaudiohrtf-spatialaudiohrtfdirectivitytype
public enum SpatialAudioHrtfDirectivityType
{
    SpatialAudioHrtfDirectivity_OmniDirectional = 0,
    SpatialAudioHrtfDirectivity_Cardioid = 1,
    SpatialAudioHrtfDirectivity_Cone = 2,
}
