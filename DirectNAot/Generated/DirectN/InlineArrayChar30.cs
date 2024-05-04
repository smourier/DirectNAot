#nullable enable
namespace DirectN;

[InlineArray(30)]
public partial struct InlineArrayChar30
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
