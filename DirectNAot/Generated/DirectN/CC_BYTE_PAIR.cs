namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CC_BYTE_PAIR
{
    public InlineArrayByte2 Decoded;
    public ushort Reserved;
}
