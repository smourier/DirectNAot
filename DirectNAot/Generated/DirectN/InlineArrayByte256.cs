#nullable enable
namespace DirectN;

[InlineArray(256)]
public partial struct InlineArrayByte256
{
    public static int Length => 256;
    
    public byte Data;
}
