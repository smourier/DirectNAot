namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_info_parmsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_INFO_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrReturn;
    public uint dwRetSize;
    public uint dwItem;
}
