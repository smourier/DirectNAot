#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_STRING
{
    public int lResult;
    public uint ulStringSize;
    public InlineArrayByte1 argbString; // variable-length array placeholder
}
