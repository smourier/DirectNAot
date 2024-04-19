namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mt_custom_video_primaries
[StructLayout(LayoutKind.Sequential)]
public partial struct MT_CUSTOM_VIDEO_PRIMARIES
{
    public float fRx;
    public float fRy;
    public float fGx;
    public float fGy;
    public float fBx;
    public float fBy;
    public float fWx;
    public float fWy;
}
