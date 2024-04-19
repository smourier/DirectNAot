namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_status_parmsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_STATUS_PARMSA
{
    public nuint dwCallback;
    public nuint dwReturn;
    public uint dwItem;
    public uint dwTrack;
    public PSTR lpstrDrive;
    public uint dwReference;
}
