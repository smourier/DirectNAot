namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_blt_state_constriction_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_BLT_STATE_CONSTRICTION_DATA
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public FoundationSIZE Size;
}
