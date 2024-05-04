#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_transfer_video_frame_flags
public enum MF_TRANSFER_VIDEO_FRAME_FLAGS
{
    MF_TRANSFER_VIDEO_FRAME_DEFAULT = 0,
    MF_TRANSFER_VIDEO_FRAME_STRETCH = 1,
    MF_TRANSFER_VIDEO_FRAME_IGNORE_PAR = 2,
}
