namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_blt_state_private_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_BLT_STATE_PRIVATE_DATA
{
    public Guid Guid;
    public uint DataSize;
    public nint pData;
}
