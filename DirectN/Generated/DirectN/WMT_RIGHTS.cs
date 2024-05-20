#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ne-wmsdkidl-wmt_rights
public enum WMT_RIGHTS
{
    WMT_RIGHT_PLAYBACK = 1,
    WMT_RIGHT_COPY_TO_NON_SDMI_DEVICE = 2,
    WMT_RIGHT_COPY_TO_CD = 8,
    WMT_RIGHT_COPY_TO_SDMI_DEVICE = 16,
    WMT_RIGHT_ONE_TIME = 32,
    WMT_RIGHT_SAVE_STREAM_PROTECTED = 64,
    WMT_RIGHT_COPY = 128,
    WMT_RIGHT_COLLABORATIVE_PLAY = 256,
    WMT_RIGHT_SDMI_TRIGGER = 65536,
    WMT_RIGHT_SDMI_NOMORECOPIES = 131072,
}
