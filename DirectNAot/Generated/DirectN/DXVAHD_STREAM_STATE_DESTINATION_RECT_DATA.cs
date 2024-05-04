namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_destination_rect_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_STREAM_STATE_DESTINATION_RECT_DATA
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public RECT DestinationRect;
}
