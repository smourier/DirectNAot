#nullable enable
namespace DirectN;

public partial struct UDCR_TAG
{
    public byte bVersion;
    public InlineArrayByte_25 KID;
    public ulong ullBaseCounter;
    public ulong ullBaseCounterRange;
    public BOOL fScrambled;
    public byte bStreamMark;
    public uint dwReserved1;
    public uint dwReserved2;
}
