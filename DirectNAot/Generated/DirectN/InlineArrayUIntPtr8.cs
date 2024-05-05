#nullable enable
namespace DirectN;

[InlineArray(8)]
public partial struct InlineArrayUIntPtr8
{
    public static int Length => 8;
    
    public nuint Data;
}
