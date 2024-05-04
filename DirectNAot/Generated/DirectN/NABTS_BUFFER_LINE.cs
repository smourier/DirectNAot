#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct NABTS_BUFFER_LINE
{
    public byte Confidence;
    public InlineArrayByte36 Bytes;
}
