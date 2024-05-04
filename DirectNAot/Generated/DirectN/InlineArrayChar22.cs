#nullable enable
namespace DirectN;

[InlineArray(22)]
public partial struct InlineArrayChar22
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
