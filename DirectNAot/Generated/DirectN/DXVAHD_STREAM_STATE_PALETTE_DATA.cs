namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_palette_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_STREAM_STATE_PALETTE_DATA
{
    public uint Count;
    public nint pEntries;
}
