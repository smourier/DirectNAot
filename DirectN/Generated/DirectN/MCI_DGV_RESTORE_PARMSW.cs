#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_restore_parmsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_RESTORE_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrFileName;
    public RECT rc;
}
