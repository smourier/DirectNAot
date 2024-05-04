#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/ns-devicetopology-ksjack_sink_information
[StructLayout(LayoutKind.Sequential)]
public partial struct KSJACK_SINK_INFORMATION
{
    public KSJACK_SINK_CONNECTIONTYPE ConnType;
    public ushort ManufacturerId;
    public ushort ProductId;
    public ushort AudioLatency;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool HDCPCapable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AICapable;
    public byte SinkDescriptionLength;
    public InlineArraySystemChar32 SinkDescription;
    public LUID PortId;
}
