#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/ns-devicetopology-ksjack_description
[StructLayout(LayoutKind.Sequential)]
public partial struct KSJACK_DESCRIPTION
{
    public uint ChannelMapping;
    public uint Color;
    public EPcxConnectionType ConnectionType;
    public EPcxGeoLocation GeoLocation;
    public EPcxGenLocation GenLocation;
    public EPxcPortConnection PortConnection;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IsConnected;
}
