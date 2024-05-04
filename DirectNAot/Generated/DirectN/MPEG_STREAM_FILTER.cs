#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MPEG_STREAM_FILTER
{
    public ushort wPidValue;
    public uint dwFilterSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fCrcEnabled;
    public InlineArrayByte16 rgchFilter;
    public InlineArrayByte16 rgchMask;
}
