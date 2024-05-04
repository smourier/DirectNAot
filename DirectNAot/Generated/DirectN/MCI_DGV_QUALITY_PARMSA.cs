#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_quality_parmsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_QUALITY_PARMSA
{
    public nuint dwCallback;
    public uint dwItem;
    public PSTR lpstrName;
    public uint lpstrAlgorithm;
    public uint dwHandle;
}
