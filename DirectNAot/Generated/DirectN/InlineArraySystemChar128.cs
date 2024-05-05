#nullable enable
namespace DirectN;

[InlineArray(128)]
public partial struct InlineArraySystemChar128
{
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
}
