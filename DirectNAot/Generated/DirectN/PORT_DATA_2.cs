namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PORT_DATA_2
{
    public InlineArraySystemChar64 sztPortName;
    public uint dwVersion;
    public uint dwProtocol;
    public uint cbSize;
    public uint dwReserved;
    public InlineArraySystemChar128 sztHostAddress;
    public InlineArrayChar33 sztSNMPCommunity;
    public uint dwDoubleSpool;
    public InlineArrayChar33 sztQueue;
    public InlineArrayByte514 Reserved;
    public uint dwPortNumber;
    public uint dwSNMPEnabled;
    public uint dwSNMPDevIndex;
    public uint dwPortMonitorMibIndex;
}
