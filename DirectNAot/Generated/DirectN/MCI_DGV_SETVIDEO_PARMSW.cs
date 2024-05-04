#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_setvideo_parmsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_SETVIDEO_PARMSW
{
    public nuint dwCallback;
    public uint dwItem;
    public uint dwValue;
    public uint dwOver;
    public PWSTR lpstrAlgorithm;
    public PWSTR lpstrQuality;
    public uint dwSourceNumber;
}
