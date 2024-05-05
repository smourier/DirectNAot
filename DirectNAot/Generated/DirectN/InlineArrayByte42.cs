#nullable enable
namespace DirectN;

[InlineArray(42)]
public partial struct InlineArrayByte42
{
    public static int Length => 42;
    
    public byte Data;
}
