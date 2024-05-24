#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/physicalmonitorenumerationapi/ns-physicalmonitorenumerationapi-physical_monitor
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PHYSICAL_MONITOR
{
    public HANDLE hPhysicalMonitor;
    public InlineArraySystemChar_128 szPhysicalMonitorDescription;
}
