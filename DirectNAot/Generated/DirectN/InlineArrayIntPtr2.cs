#nullable enable
namespace DirectN;

[InlineArray(2)]
public partial struct InlineArrayIntPtr2
{
    public static int Length => 2;
    
    public nint Data;
}
