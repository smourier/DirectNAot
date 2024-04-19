namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_ISDBCAS_RESPONSEDATA
{
    public int lResult;
    public uint ulRequestID;
    public uint ulIsdbStatus;
    public uint ulIsdbDataSize;
    public InlineArrayByte1 argbIsdbCommandData; // variable-length array placeholder
}
