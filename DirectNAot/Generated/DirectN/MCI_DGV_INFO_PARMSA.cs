#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_info_parmsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_INFO_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrReturn;
    public uint dwRetSize;
    public uint dwItem;
}
