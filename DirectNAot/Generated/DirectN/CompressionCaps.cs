namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-compressioncaps
public enum CompressionCaps
{
    CompressionCaps_CanQuality = 1,
    CompressionCaps_CanCrunch = 2,
    CompressionCaps_CanKeyFrame = 4,
    CompressionCaps_CanBFrame = 8,
    CompressionCaps_CanWindow = 16,
}
