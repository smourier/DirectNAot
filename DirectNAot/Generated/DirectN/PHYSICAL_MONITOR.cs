#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/physicalmonitorenumerationapi/ns-physicalmonitorenumerationapi-physical_monitor
[StructLayout(LayoutKind.Sequential)]
public partial struct PHYSICAL_MONITOR
{
    public HANDLE hPhysicalMonitor;
    public InlineArraySystemChar128 szPhysicalMonitorDescription;
}
