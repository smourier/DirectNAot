#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_ISDBCAS_REQUESTHEADER
{
    public byte bInstruction;
    public InlineArrayByte_3 bReserved;
    public uint ulDataLength;
    public InlineArrayByte_1 argbIsdbCommand; // variable-length array placeholder
}
