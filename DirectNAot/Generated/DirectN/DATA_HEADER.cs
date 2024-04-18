namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DATA_HEADER
{
    public uint dwSignature;
    public ushort wSize;
    public ushort wDataID;
    public uint dwDataSize;
    public uint dwReserved;
}
