#nullable enable
namespace DirectN;

[InlineArray(1)]
public partial struct InlineArraySystemChar1
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
