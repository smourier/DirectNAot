namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KERNDATA
{
    public uint dwSize;
    public uint dwKernPairNum;
    public InlineArrayFD_KERNINGPAIR1 KernPair; // variable-length array placeholder
}
