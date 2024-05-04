#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_cue_parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_CUE_PARMS
{
    public nuint dwCallback;
    public uint dwTo;
}
