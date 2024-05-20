#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_setaudio_parmsw
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_SETAUDIO_PARMSW
{
    public nuint dwCallback;
    public uint dwItem;
    public uint dwValue;
    public uint dwOver;
    public PWSTR lpstrAlgorithm;
    public PWSTR lpstrQuality;
}
