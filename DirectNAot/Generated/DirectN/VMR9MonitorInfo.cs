#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9monitorinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9MonitorInfo
{
    public uint uDevID;
    public RECT rcMonitor;
    public HMONITOR hMon;
    public uint dwFlags;
    public InlineArraySystemChar_32 szDevice;
    public InlineArraySystemChar_512 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
}
