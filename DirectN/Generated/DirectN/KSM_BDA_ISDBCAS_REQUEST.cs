#nullable enable
namespace DirectN;

public partial struct KSM_BDA_ISDBCAS_REQUEST
{
    public KSM_NODE NodeMethod;
    public uint ulRequestID;
    public uint ulIsdbCommandSize;
    public InlineArrayByte_1 argbIsdbCommandData; // variable-length array placeholder
}
