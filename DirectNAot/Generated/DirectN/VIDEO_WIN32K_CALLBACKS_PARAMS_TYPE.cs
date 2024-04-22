namespace DirectN;

public enum VIDEO_WIN32K_CALLBACKS_PARAMS_TYPE
{
    VideoPowerNotifyCallout = 1,
    VideoEnumChildPdoNotifyCallout = 3,
    VideoFindAdapterCallout = 4,
    VideoPnpNotifyCallout = 7,
    VideoDxgkDisplaySwitchCallout = 8,
    VideoDxgkFindAdapterTdrCallout = 10,
    VideoDxgkHardwareProtectionTeardown = 11,
    VideoRepaintDesktop = 12,
    VideoUpdateCursor = 13,
    VideoDisableMultiPlaneOverlay = 14,
    VideoDesktopDuplicationChange = 15,
    VideoBlackScreenDiagnostics = 16,
}
