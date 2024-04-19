namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/ne-qnetwork-amextendedseekingcapabilities
public enum AMExtendedSeekingCapabilities
{
    AM_EXSEEK_CANSEEK = 1,
    AM_EXSEEK_CANSCAN = 2,
    AM_EXSEEK_MARKERSEEK = 4,
    AM_EXSEEK_SCANWITHOUTCLOCK = 8,
    AM_EXSEEK_NOSTANDARDREPAINT = 16,
    AM_EXSEEK_BUFFERING = 32,
    AM_EXSEEK_SENDS_VIDEOFRAMEREADY = 64,
}
