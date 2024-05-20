#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/ns-spatialaudiohrtf-spatialaudiohrtfactivationparams2
[StructLayout(LayoutKind.Sequential)]
public partial struct SpatialAudioHrtfActivationParams2
{
    public nint ObjectFormat;
    public AudioObjectType StaticObjectTypeMask;
    public uint MinDynamicObjectCount;
    public uint MaxDynamicObjectCount;
    public AUDIO_STREAM_CATEGORY Category;
    public HANDLE EventHandle;
    public nint NotifyObject;
    public nint DistanceDecay;
    public nint Directivity;
    public nint Environment;
    public nint Orientation;
    public SPATIAL_AUDIO_STREAM_OPTIONS Options;
}
