namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MONITOR2
{
    public uint cbSize;
    public nint pfnEnumPorts;
    public nint pfnOpenPort;
    public nint pfnOpenPortEx;
    public nint pfnStartDocPort;
    public nint pfnWritePort;
    public nint pfnReadPort;
    public nint pfnEndDocPort;
    public nint pfnClosePort;
    public nint pfnAddPort;
    public nint pfnAddPortEx;
    public nint pfnConfigurePort;
    public nint pfnDeletePort;
    public nint pfnGetPrinterDataFromPort;
    public nint pfnSetPortTimeOuts;
    public nint pfnXcvOpenPort;
    public nint pfnXcvDataPort;
    public nint pfnXcvClosePort;
    public nint pfnShutdown;
    public nint pfnSendRecvBidiDataFromPort;
    public nint pfnNotifyUsedPorts;
    public nint pfnNotifyUnusedPorts;
    public nint pfnPowerEvent;
}
