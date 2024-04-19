namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_reserve_parmsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_RESERVE_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrPath;
    public uint dwSize;
}
