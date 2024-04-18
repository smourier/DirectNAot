namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DELETE_PORT_DATA_1
{
    public InlineArraySystemChar64 psztPortName;
    public InlineArrayByte98 Reserved;
    public uint dwVersion;
    public uint dwReserved;
}
