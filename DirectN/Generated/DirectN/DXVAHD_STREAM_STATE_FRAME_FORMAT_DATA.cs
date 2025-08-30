#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_frame_format_data
public partial struct DXVAHD_STREAM_STATE_FRAME_FORMAT_DATA : IValueGet<DXVAHD_FRAME_FORMAT>
{
    public DXVAHD_FRAME_FORMAT FrameFormat;
    
    readonly DXVAHD_FRAME_FORMAT IValueGet<DXVAHD_FRAME_FORMAT>.GetValue() => FrameFormat;
    readonly object? IValueGet.GetValue() => FrameFormat;
}
