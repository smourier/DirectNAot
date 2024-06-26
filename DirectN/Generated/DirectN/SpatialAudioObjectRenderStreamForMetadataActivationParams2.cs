﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/ns-spatialaudiometadata-spatialaudioobjectrenderstreamformetadataactivationparams2
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioObjectRenderStreamForMetadataActivationParams2
{
    public nint ObjectFormat;
    public AudioObjectType StaticObjectTypeMask;
    public uint MinDynamicObjectCount;
    public uint MaxDynamicObjectCount;
    public AUDIO_STREAM_CATEGORY Category;
    public HANDLE EventHandle;
    public Guid MetadataFormatId;
    public uint MaxMetadataItemCount;
    public nint MetadataActivationParams;
    public nint NotifyObject;
    public SPATIAL_AUDIO_STREAM_OPTIONS Options;
}
