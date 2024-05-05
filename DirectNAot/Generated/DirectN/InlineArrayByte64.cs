#nullable enable
namespace DirectN;

[InlineArray(64)]
public partial struct InlineArrayByte64
{
    public static int Length => 64;
    
    public byte Data;
}
