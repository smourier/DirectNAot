#nullable enable
namespace DirectN;

[InlineArray(27)]
public partial struct InlineArrayChar27
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
