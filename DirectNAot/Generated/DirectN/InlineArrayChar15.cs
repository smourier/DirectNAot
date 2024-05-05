#nullable enable
namespace DirectN;

[InlineArray(15)]
public partial struct InlineArrayChar15
{
    public static int Length => 15;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
