#nullable enable
namespace DirectN;

[InlineArray(15)]
public partial struct InlineArrayChar15
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
