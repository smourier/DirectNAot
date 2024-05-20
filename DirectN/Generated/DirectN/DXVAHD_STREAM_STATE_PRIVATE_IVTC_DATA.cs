#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_private_ivtc_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_STREAM_STATE_PRIVATE_IVTC_DATA
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public uint ITelecineFlags;
    public uint Frames;
    public uint InputField;
}
