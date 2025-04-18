#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_STREAM_FILTER
{
    public ushort wPidValue;
    public uint dwFilterSize;
    public BOOL fCrcEnabled;
    public InlineArrayByte_16 rgchFilter;
    public InlineArrayByte_16 rgchMask;
}
