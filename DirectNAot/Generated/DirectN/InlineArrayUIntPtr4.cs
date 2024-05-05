#nullable enable
namespace DirectN;

[InlineArray(4)]
public partial struct InlineArrayUIntPtr4
{
    public static int Length => 4;
    
    public nuint Data;
}
