#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct BDA_ISDBCAS_RESPONSEDATA
{
    public int lResult;
    public uint ulRequestID;
    public uint ulIsdbStatus;
    public uint ulIsdbDataSize;
    public InlineArrayByte_1 argbIsdbCommandData; // variable-length array placeholder
}
