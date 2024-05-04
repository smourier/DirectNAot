#nullable enable
namespace DirectN;

public enum KS_SEEKING_FLAGS
{
    KS_SEEKING_NoPositioning = 0,
    KS_SEEKING_AbsolutePositioning = 1,
    KS_SEEKING_RelativePositioning = 2,
    KS_SEEKING_IncrementalPositioning = 3,
    KS_SEEKING_PositioningBitsMask = 3,
    KS_SEEKING_SeekToKeyFrame = 4,
    KS_SEEKING_ReturnTime = 8,
}
