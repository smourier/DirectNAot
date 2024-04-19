namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_content_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_CONTENT_DESC
{
    public DXVAHD_FRAME_FORMAT InputFrameFormat;
    public DXVAHD_RATIONAL InputFrameRate;
    public uint InputWidth;
    public uint InputHeight;
    public DXVAHD_RATIONAL OutputFrameRate;
    public uint OutputWidth;
    public uint OutputHeight;
}
