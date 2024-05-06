#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ColorLUTParams
{
    public InlineArrayByte_256 lutB;
    public InlineArrayByte_256 lutG;
    public InlineArrayByte_256 lutR;
    public InlineArrayByte_256 lutA;
}
