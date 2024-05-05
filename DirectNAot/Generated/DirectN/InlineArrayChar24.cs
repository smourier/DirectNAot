#nullable enable
namespace DirectN;

[InlineArray(24)]
public partial struct InlineArrayChar24
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
