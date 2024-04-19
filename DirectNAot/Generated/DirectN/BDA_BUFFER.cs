namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_BUFFER
{
    public int lResult;
    public uint ulBufferSize;
    public InlineArrayByte1 argbBuffer; // variable-length array placeholder
}
