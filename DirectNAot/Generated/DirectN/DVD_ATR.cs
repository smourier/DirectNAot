namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_ATR
{
    public uint ulCAT;
    public InlineArrayByte768 pbATRI;
}
