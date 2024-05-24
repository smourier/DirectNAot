#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudioclient/ns-spatialaudioclient-spatialaudioobjectrenderstreamactivationparams
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioObjectRenderStreamActivationParams
{
    public nint ObjectFormat;
    public AudioObjectType StaticObjectTypeMask;
    public uint MinDynamicObjectCount;
    public uint MaxDynamicObjectCount;
    public AUDIO_STREAM_CATEGORY Category;
    public HANDLE EventHandle;
    public nint NotifyObject;
}
