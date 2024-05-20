#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/ns-spatialaudiometadata-spatialaudioobjectrenderstreamformetadataactivationparams
[StructLayout(LayoutKind.Sequential)]
public partial struct SpatialAudioObjectRenderStreamForMetadataActivationParams
{
    public nint ObjectFormat;
    public AudioObjectType StaticObjectTypeMask;
    public uint MinDynamicObjectCount;
    public uint MaxDynamicObjectCount;
    public AUDIO_STREAM_CATEGORY Category;
    public HANDLE EventHandle;
    public Guid MetadataFormatId;
    public ushort MaxMetadataItemCount;
    public nint MetadataActivationParams;
    public nint NotifyObject;
}
