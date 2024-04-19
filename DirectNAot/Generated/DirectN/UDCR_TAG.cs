namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct UDCR_TAG
{
    public byte bVersion;
    public InlineArrayByte25 KID;
    public ulong ullBaseCounter;
    public ulong ullBaseCounterRange;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fScrambled;
    public byte bStreamMark;
    public uint dwReserved1;
    public uint dwReserved2;
}
