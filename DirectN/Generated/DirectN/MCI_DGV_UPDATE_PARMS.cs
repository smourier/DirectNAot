#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_update_parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_DGV_UPDATE_PARMS
{
    public nuint dwCallback;
    public RECT rc;
    public HDC hDC;
}
