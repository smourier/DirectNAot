#nullable enable
namespace DirectN;

[InlineArray(18)]
public partial struct InlineArrayChar18
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
