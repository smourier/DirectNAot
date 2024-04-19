namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_filter_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_STREAM_STATE_FILTER_DATA
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public int Level;
}
