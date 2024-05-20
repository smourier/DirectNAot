#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2Trace_VideoProcessDevCreatedData
{
    public EVENT_TRACE_HEADER wmiHeader;
    public ulong pObject;
    public ulong pD3DDevice;
    public Guid DeviceGuid;
    public uint RTFourCC;
    public uint Width;
    public uint Height;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Enter;
}
