#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_capture_parmsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_CAPTURE_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrFileName;
    public RECT rc;
}
