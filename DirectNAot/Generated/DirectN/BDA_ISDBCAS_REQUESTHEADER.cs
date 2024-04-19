namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_ISDBCAS_REQUESTHEADER
{
    public byte bInstruction;
    public InlineArrayByte3 bReserved;
    public uint ulDataLength;
    public InlineArrayByte1 argbIsdbCommand; // variable-length array placeholder
}
