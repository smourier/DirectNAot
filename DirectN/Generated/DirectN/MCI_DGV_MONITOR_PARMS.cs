#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_monitor_parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_MONITOR_PARMS
{
    public nuint dwCallback;
    public uint dwSource;
    public uint dwMethod;
}
