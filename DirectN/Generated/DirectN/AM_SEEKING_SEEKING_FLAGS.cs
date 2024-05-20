#nullable enable
namespace DirectN;

public enum AM_SEEKING_SEEKING_FLAGS
{
    AM_SEEKING_NoPositioning = 0,
    AM_SEEKING_AbsolutePositioning = 1,
    AM_SEEKING_RelativePositioning = 2,
    AM_SEEKING_IncrementalPositioning = 3,
    AM_SEEKING_PositioningBitsMask = 3,
    AM_SEEKING_SeekToKeyFrame = 4,
    AM_SEEKING_ReturnTime = 8,
    AM_SEEKING_Segment = 16,
    AM_SEEKING_NoFlush = 32,
}
