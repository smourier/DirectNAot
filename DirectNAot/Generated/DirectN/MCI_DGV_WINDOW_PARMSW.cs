namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_window_parmsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_WINDOW_PARMSW
{
    public nuint dwCallback;
    public HWND hWnd;
    public uint nCmdShow;
    public PWSTR lpstrText;
}
