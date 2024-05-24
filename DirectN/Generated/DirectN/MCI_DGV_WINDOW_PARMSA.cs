#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_window_parmsa
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_DGV_WINDOW_PARMSA
{
    public nuint dwCallback;
    public HWND hWnd;
    public uint nCmdShow;
    public PSTR lpstrText;
}
