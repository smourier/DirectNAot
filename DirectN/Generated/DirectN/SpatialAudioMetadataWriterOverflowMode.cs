#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/ne-spatialaudiometadata-spatialaudiometadatawriteroverflowmode
public enum SpatialAudioMetadataWriterOverflowMode
{
    SpatialAudioMetadataWriterOverflow_Fail = 0,
    SpatialAudioMetadataWriterOverflow_MergeWithNew = 1,
    SpatialAudioMetadataWriterOverflow_MergeWithLast = 2,
}
