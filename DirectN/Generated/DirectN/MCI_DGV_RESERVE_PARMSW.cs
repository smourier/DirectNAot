#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_reserve_parmsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_RESERVE_PARMSW
{
    public nuint dwCallback;
    public PWSTR lpstrPath;
    public uint dwSize;
}
