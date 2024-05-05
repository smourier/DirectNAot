#nullable enable
namespace DirectN;

[InlineArray(32)]
public partial struct InlineArrayGuid32
{
    public static int Length => 32;
    
    public Guid Data;
}
