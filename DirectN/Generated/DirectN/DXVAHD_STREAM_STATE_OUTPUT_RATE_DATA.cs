#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_output_rate_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA
{
    public BOOL RepeatFrame;
    public DXVAHD_OUTPUT_RATE OutputRate;
    public DXVAHD_RATIONAL CustomRate;
}
