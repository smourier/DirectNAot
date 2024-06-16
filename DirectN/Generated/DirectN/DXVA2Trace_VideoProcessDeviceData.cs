#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2Trace_VideoProcessDeviceData
{
    public EVENT_TRACE_HEADER wmiHeader;
    public ulong pObject;
    public BOOL Enter;
}
