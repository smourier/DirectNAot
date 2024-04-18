namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MONITOREX
{
    public uint dwMonitorSize;
    public MONITOR Monitor;
}
