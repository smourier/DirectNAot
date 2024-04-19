namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_rect_parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_RECT_PARMS
{
    public nuint dwCallback;
    public FoundationRECT rc;
}
