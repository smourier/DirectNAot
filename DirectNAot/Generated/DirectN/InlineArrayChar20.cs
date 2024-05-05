#nullable enable
namespace DirectN;

[InlineArray(20)]
public partial struct InlineArrayChar20
{
    public static int Length => 20;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
