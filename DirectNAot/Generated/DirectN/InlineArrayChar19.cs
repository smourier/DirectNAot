#nullable enable
namespace DirectN;

[InlineArray(19)]
public partial struct InlineArrayChar19
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
