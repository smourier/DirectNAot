namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9monitorinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9MonitorInfo
{
    public uint uDevID;
    public FoundationRECT rcMonitor;
    public HMONITOR hMon;
    public uint dwFlags;
    public InlineArraySystemChar32 szDevice;
    public InlineArraySystemChar512 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
}
