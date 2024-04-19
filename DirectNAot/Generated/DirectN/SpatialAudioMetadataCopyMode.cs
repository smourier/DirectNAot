namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/ne-spatialaudiometadata-spatialaudiometadatacopymode
public enum SpatialAudioMetadataCopyMode
{
    SpatialAudioMetadataCopy_Overwrite = 0,
    SpatialAudioMetadataCopy_Append = 1,
    SpatialAudioMetadataCopy_AppendMergeWithLast = 2,
    SpatialAudioMetadataCopy_AppendMergeWithFirst = 3,
}
