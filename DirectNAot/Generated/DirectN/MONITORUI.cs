namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MONITORUI
{
    public uint dwMonitorUISize;
    public nint pfnAddPortUI;
    public nint pfnConfigurePortUI;
    public nint pfnDeletePortUI;
}
