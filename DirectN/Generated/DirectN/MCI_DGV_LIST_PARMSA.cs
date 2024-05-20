#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_list_parmsa
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_LIST_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrReturn;
    public uint dwLength;
    public uint dwNumber;
    public uint dwItem;
    public PSTR lpstrAlgorithm;
}
