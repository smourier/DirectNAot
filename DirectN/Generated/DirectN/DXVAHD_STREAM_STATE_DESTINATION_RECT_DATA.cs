#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_destination_rect_data
public partial struct DXVAHD_STREAM_STATE_DESTINATION_RECT_DATA
{
    public BOOL Enable;
    public RECT DestinationRect;
}
