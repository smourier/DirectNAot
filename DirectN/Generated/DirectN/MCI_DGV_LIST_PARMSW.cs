#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_list_parmsw
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_DGV_LIST_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrReturn;
    public uint dwLength;
    public uint dwNumber;
    public uint dwItem;
    public PWSTR lpstrAlgorithm;
}
