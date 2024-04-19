namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_open_parmsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_OPEN_PARMSW
{
    public nuint dwCallback;
    public uint wDeviceID;
    public PWSTR lpstrDeviceType;
    public PWSTR lpstrElementName;
    public PWSTR lpstrAlias;
    public uint dwStyle;
    public HWND hWndParent;
}
