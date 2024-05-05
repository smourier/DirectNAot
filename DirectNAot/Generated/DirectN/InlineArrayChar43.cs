#nullable enable
namespace DirectN;

[InlineArray(43)]
public partial struct InlineArrayChar43
{
    public static int Length => 43;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
