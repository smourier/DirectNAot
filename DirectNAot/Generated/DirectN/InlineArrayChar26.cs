#nullable enable
namespace DirectN;

[InlineArray(26)]
public partial struct InlineArrayChar26
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
