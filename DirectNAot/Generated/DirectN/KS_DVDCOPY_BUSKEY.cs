namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DVDCOPY_BUSKEY
{
    public InlineArrayByte5 BusKey;
    public InlineArrayByte1 Reserved; // variable-length array placeholder
}
