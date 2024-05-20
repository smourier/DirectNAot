#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_save_parmsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_SAVE_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrFileName;
    public RECT rc;
}
