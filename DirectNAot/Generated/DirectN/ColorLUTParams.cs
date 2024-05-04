#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ColorLUTParams
{
    public InlineArrayByte256 lutB;
    public InlineArrayByte256 lutG;
    public InlineArrayByte256 lutR;
    public InlineArrayByte256 lutA;
}
