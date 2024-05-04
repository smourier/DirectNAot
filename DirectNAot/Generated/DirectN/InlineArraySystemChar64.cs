#nullable enable
namespace DirectN;

[InlineArray(64)]
public partial struct InlineArraySystemChar64
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString();
}
