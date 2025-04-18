#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_aspect_ratio_data
public partial struct DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA
{
    public BOOL Enable;
    public DXVAHD_RATIONAL SourceAspectRatio;
    public DXVAHD_RATIONAL DestinationAspectRatio;
}
