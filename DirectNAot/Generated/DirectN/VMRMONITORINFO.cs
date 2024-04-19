namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrmonitorinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMRMONITORINFO
{
    public VMRGUID guid;
    public FoundationRECT rcMonitor;
    public HMONITOR hMon;
    public uint dwFlags;
    public InlineArraySystemChar32 szDevice;
    public InlineArraySystemChar256 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
}
