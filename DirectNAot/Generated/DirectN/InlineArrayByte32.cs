#nullable enable
namespace DirectN;

[InlineArray(32)]
public partial struct InlineArrayByte32
{
    public static int Length => 32;
    
    public byte Data;
}
