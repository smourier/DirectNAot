#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_private_data
public partial struct DXVAHD_STREAM_STATE_PRIVATE_DATA
{
    public Guid Guid;
    public uint DataSize;
    public nint pData;
}
