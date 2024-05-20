#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_luma_key_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_STREAM_STATE_LUMA_KEY_DATA
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public float Lower;
    public float Upper;
}
