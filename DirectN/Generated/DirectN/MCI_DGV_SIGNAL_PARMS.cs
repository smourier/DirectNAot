#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_signal_parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_SIGNAL_PARMS
{
    public nuint dwCallback;
    public uint dwPosition;
    public uint dwPeriod;
    public uint dwUserParm;
}
