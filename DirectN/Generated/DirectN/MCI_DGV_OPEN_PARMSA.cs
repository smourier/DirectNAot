#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_open_parmsa
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_DGV_OPEN_PARMSA
{
    public nuint dwCallback;
    public uint wDeviceID;
    public PSTR lpstrDeviceType;
    public PSTR lpstrElementName;
    public PSTR lpstrAlias;
    public uint dwStyle;
    public HWND hWndParent;
}
