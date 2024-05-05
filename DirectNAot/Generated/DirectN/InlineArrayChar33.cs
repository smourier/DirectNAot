#nullable enable
namespace DirectN;

[InlineArray(33)]
public partial struct InlineArrayChar33
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
