namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiohrtf/ns-spatialaudiohrtf-spatialaudiohrtfactivationparams
[StructLayout(LayoutKind.Sequential)]
public partial struct SpatialAudioHrtfActivationParams
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
}
