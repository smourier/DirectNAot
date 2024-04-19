namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_frame_format_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_STREAM_STATE_FRAME_FORMAT_DATA
{
    public DXVAHD_FRAME_FORMAT FrameFormat;
}
