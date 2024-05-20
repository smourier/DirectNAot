#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrmonitorinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMRMONITORINFO
{
    public VMRGUID guid;
    public RECT rcMonitor;
    public HMONITOR hMon;
    public uint dwFlags;
    public InlineArraySystemChar_32 szDevice;
    public InlineArraySystemChar_256 szDescription;
    public long liDriverVersion;
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
}
