#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/ne-mfplay-_mfp_mediaitem_characteristics
public enum _MFP_MEDIAITEM_CHARACTERISTICS
{
    MFP_MEDIAITEM_IS_LIVE = 1,
    MFP_MEDIAITEM_CAN_SEEK = 2,
    MFP_MEDIAITEM_CAN_PAUSE = 4,
    MFP_MEDIAITEM_HAS_SLOW_SEEK = 8,
}
