#nullable enable
namespace DirectN;

[InlineArray(2)]
public partial struct InlineArrayUIntPtr2
{
    public static int Length => 2;
    
    public nuint Data;
}
