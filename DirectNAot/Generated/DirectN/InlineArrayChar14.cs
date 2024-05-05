#nullable enable
namespace DirectN;

[InlineArray(14)]
public partial struct InlineArrayChar14
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
