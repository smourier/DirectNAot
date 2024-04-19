namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_restore_parmsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_RESTORE_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrFileName;
    public FoundationRECT rc;
}
