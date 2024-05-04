#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_GDDS_DATA
{
    public int lResult;
    public uint ulDataLength;
    public uint ulPercentageProgress;
    public InlineArrayByte1 argbData; // variable-length array placeholder
}
