#nullable enable
namespace DirectN;

public enum KS_CompressionCaps
{
    KS_CompressionCaps_CanQuality = 1,
    KS_CompressionCaps_CanCrunch = 2,
    KS_CompressionCaps_CanKeyFrame = 4,
    KS_CompressionCaps_CanBFrame = 8,
    KS_CompressionCaps_CanWindow = 16,
}
